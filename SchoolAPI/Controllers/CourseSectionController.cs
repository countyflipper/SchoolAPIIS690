using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using SchoolAPI.ActionFilters;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace SchoolAPI.Controllers
{
    [Route("api/v1/CourseSection")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class CourseSectionController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        // private readonly IDataShaper<UserDto> _dataShaper;


        public CourseSectionController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            // _dataShaper = dataShaper;
        }

        [HttpGet]
        public IActionResult GetCourseSection()
        {
            //try
            //{
            var organizations = _repository.CourseSection.GetAllCourseSections(trackChanges: false);

            var UserDto = _mapper.Map<IEnumerable<CourseSectionDto>>(organizations);
            return Ok(organizations);
            /*var organizationDto = _mapper.Map<IEnumerable<OrganizationDto>>(organizations);
            return Ok(organizationDto);*/

            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError($"Something went wrong in the {nameof(GetCourseManages)} action {ex}");
            //    return StatusCode(500, "Internal server error");
            //}
        }



        [HttpGet("{id}")]
        public IActionResult GetCourseSection(Guid id)
        {
            try
            {
                var organization = _repository.CourseSection.GetCourseSection(id, trackChanges: false); if (organization == null)
                {
                    _logger.LogInfo($"Organization with id: {id} doesn't exist in the database.");
                    return NotFound();
                }
                else
                {
                    var organizationDto = _mapper.Map<CourseSectionDto>(organization);
                    return Ok(organizationDto);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetCourseSection)} action {ex}");
                return StatusCode(500, "Internal server error");
            }

        }

        /**************************************************************************************/


        [HttpPost(Name = "CourseSectionByID"), Authorize(Roles = "Administrator")]
        public IActionResult CreateCourseSection([FromBody] CourseSectionForCreationDto coursesection)
        {
            if (coursesection == null)
            {
                _logger.LogError("CourseManage ForCreationDto object sent from client is null.");
                return BadRequest("CourseManage ForCreationDto object is null");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the CourseSectionForCreationDto object");
                return UnprocessableEntity(ModelState);
            }
            var coursesectionEntity = _mapper.Map<CourseSection>(coursesection);

            _repository.CourseSection.CreateCourseSection(coursesectionEntity);
            _repository.Save();

            var userToReturn = _mapper.Map<CourseSectionDto>(coursesectionEntity);

            return CreatedAtRoute("CourseSectionByID", new { id = userToReturn.Id }, userToReturn);
        }

        /**************************************************************************************/
        [HttpPut("{id}")]
        public IActionResult UpdateCourseSection(Guid id, [FromBody] CourseSectionUpdateForDto coursesection)
        {
            if (coursesection == null)
            {
                _logger.LogError("CourseSectionUpdateForDto object sent from client is null.");
                return BadRequest("CourseSectionUpdateForDto object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the CourseSectionupdateForDto object");
                return UnprocessableEntity(ModelState);
            }
            var coursesectionEntity = _repository.CourseSection.GetCourseSection(id, trackChanges: true);
            if (coursesectionEntity == null)
            {
                _logger.LogInfo($"CourseManage with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _mapper.Map(coursesection, coursesectionEntity);
            _repository.Save();

            return NoContent();
        }

        /**************************************************************************************/
        [HttpDelete("{id}")]
        public IActionResult DeleteCourseSection(Guid id)
        {
            var organization = _repository.CourseSection.GetCourseSection(id, trackChanges: false);
            if (organization == null)
            {
                _logger.LogInfo($"CourseSection with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _repository.CourseSection.DeleteCourseSection(organization);
            _repository.Save();

            return NoContent();
        }
        /**************************************************************************************/

        [HttpPatch("{id}")]
        public IActionResult PartiallyUpdateCourseSection(Guid id, [FromBody] JsonPatchDocument<CourseSectionUpdateForDto> patchDoc)
        {
  
            
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from client is null.");
                return BadRequest("patchDoc object is null");
            }

            var coursesectionEntity = _repository.CourseSection.GetCourseSection( id, trackChanges: true);
            if (coursesectionEntity == null)
            {
                _logger.LogInfo($"Course Section with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            var coursesectionToPatch = _mapper.Map<CourseSectionUpdateForDto>(coursesectionEntity);

            patchDoc.ApplyTo(coursesectionToPatch);

            _mapper.Map(coursesectionToPatch, coursesectionEntity);


                _repository.Save();

                return NoContent();
          
        }

    }
}
