using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.RequestFeatures;
using SchoolAPI.ActionFilters;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Authorization;

namespace SchoolAPI.Controllers
{
    [Route("api/v1/SectionEnrollmentManage")]
    [ApiController]
    public class SectionEnrollmentManageController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SectionEnrollmentManageController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSectionEnrollmentManage([FromQuery] SectionEnrollmentManageParameters employeeParameters)
        {
            //var company = await _repository.Course.GetCourseAsync(companyId, trackChanges: false);
            //if (company == null)
            //{
            //    _logger.LogInfo($"Company with id: {companyId} doesn't exist in the database.");
            //    return NotFound();
            //}

            var employeesFromDb = await _repository.SectionEnrollManage.GetSectionEnrollManageAsync(employeeParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(employeesFromDb.MetaData));

            var employeesDto = _mapper.Map<IEnumerable<SectionEnrollManage>>(employeesFromDb);

            return Ok(employeesDto);
        }

        [HttpGet("{id}", Name = "GetASectionEnrollmentManage")]
        public IActionResult GetASectionEnrollmentManage(Guid coursesectionID, Guid id)
        {
            //var coursesection = _repository.CourseSection.GetCourseSection(coursesectionID, trackChanges: false);
            //if (coursesection == null)
            //{
            //    _logger.LogInfo($"Company with id: {coursesectionID} doesn't exist in the database.");
            //    return NotFound();
            //}

            var courseID = _repository.SectionEnrollManage.GetASectionEnrollManage(id, trackChanges: false);
            if (courseID == null)
            {
                _logger.LogInfo($"Employee with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            var employee = _mapper.Map<SectionEnrollmentManageDto>(courseID);

            return Ok(employee);
        }


        [HttpPost(Name = "SectionEnrollManageByID"), Authorize(Roles = "Administrator")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public IActionResult CreateNewSectionEnrollmentManage([FromBody] SectionEnrollmentManageDto course)
        {
            if (course == null)
            {
                _logger.LogError("User ForCreationDto object sent from client is null.");
                return BadRequest("User ForCreationDto object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the UserForUpdateDto object");
                return UnprocessableEntity(ModelState);
            }

            var courseEntity = _mapper.Map<SectionEnrollManage>(course);

            _repository.SectionEnrollManage.CreateSectionEnrollManage(courseEntity);
            _repository.Save();

            var userToReturn = _mapper.Map<SectionEnrollmentManageDto>(courseEntity);

            return CreatedAtRoute("SectionEnrollManageByID", new { id = userToReturn.Id }, userToReturn);
        }
        /**************************************************************************************/
        [HttpDelete("{id}")]
        public IActionResult DeleteSectionEnrollmentManage(Guid id)
        {
            var course = _repository.SectionEnrollManage.GetASectionEnrollManage(id, trackChanges: false);
            if (course == null)
            {
                _logger.LogInfo($"Course with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _repository.SectionEnrollManage.DeleteSectionEnrollManage(course);
            _repository.Save();

            return NoContent();
        }
        /**************************************************************************************/
        [HttpPut("{id}")]
        public IActionResult UpdateSectionEnrollmentManage(Guid id, [FromBody] SectionEnrollmentManageForUpdateDto course)
        {
            if (course == null)
            {
                _logger.LogError("CourseSectionUpdateForDto object sent from client is null.");
                return BadRequest("CourseSectionUpdateForDto object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the CourseSectionupdateForDto object");
                return UnprocessableEntity(ModelState);
            }
            var coursesectionEntity = _repository.Course.GetACourse(id, trackChanges: true);
            if (coursesectionEntity == null)
            {
                _logger.LogInfo($"CourseManage with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _mapper.Map(course, coursesectionEntity);
            _repository.Save();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PartiallyUpdateSectionEnrollmentManage(Guid id, [FromBody] JsonPatchDocument<SectionEnrollmentManageForUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from client is null.");
                return BadRequest("patchDoc object is null");
            }

            var courseEntity = _repository.SectionEnrollManage.GetASectionEnrollManage(id, trackChanges: true);
            if (courseEntity == null)
            {
                _logger.LogInfo($"Course Section with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            var courseToPatch = _mapper.Map<SectionEnrollmentManageForUpdateDto>(courseEntity);

            patchDoc.ApplyTo(courseToPatch);

            _mapper.Map(courseToPatch, courseEntity);


            _repository.Save();

            return NoContent();
        }
    }
}