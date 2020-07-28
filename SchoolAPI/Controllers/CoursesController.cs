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
    [Route("api/v1/Courses")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CoursesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCourses( [FromQuery] CoursesParameters employeeParameters)
        {
            //var company = await _repository.Course.GetCourseAsync(companyId, trackChanges: false);
            //if (company == null)
            //{
            //    _logger.LogInfo($"Company with id: {companyId} doesn't exist in the database.");
            //    return NotFound();
            //}

            var employeesFromDb = await _repository.Course.GetCoursesAsync( employeeParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(employeesFromDb.MetaData));

            var employeesDto = _mapper.Map<IEnumerable<CourseDto>>(employeesFromDb);

            return Ok(employeesDto);
        }

        [HttpGet("{id}", Name = "GetACourse")]
        public IActionResult GetCourseSectionForCourses(Guid coursesectionID, Guid id)
        {
            var coursesection = _repository.CourseSection.GetCourseSection(coursesectionID, trackChanges: false);
            if (coursesection == null)
            {
                _logger.LogInfo($"Company with id: {coursesectionID} doesn't exist in the database.");
                return NotFound();
            }

            var courseID = _repository.Course.GetCourse(coursesectionID, id, trackChanges: false);
            if (courseID == null)
            {
                _logger.LogInfo($"Employee with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            var employee = _mapper.Map<CourseDto>(courseID);

            return Ok(employee);
        }


        [HttpPost(Name = "CourseByID"), Authorize(Roles = "Administrator")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public IActionResult CreateNewCourse([FromBody] CourseForCreationDto course)
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

            var courseEntity = _mapper.Map<Courses>(course);

            _repository.Course.CreateCourse(courseEntity);
            _repository.Save();

            var userToReturn = _mapper.Map<CourseDto>(courseEntity);

            return CreatedAtRoute("CourseByID", new { id = userToReturn.id }, userToReturn);
        }
        /**************************************************************************************/
        [HttpDelete("{id}")]
        public IActionResult DeleteCourseSection(Guid id)
        {
            var course = _repository.Course.GetACourse(id, trackChanges: false);
            if (course == null)
            {
                _logger.LogInfo($"Course with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _repository.Course.DeleteCourse(course);
            _repository.Save();

            return NoContent();
        }
        /**************************************************************************************/
        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateCourseExistsAttribute))]
        public async Task<IActionResult> UpdateEmployeeForCompany(Guid companyId, Guid id, [FromBody] CourseForUpdateDto employee)
        {
            var employeeEntity = HttpContext.Items["employee"] as Courses;

            _mapper.Map(employee, employeeEntity);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult>PartiallyUpdateCourses(Guid id, [FromBody] JsonPatchDocument<CourseForUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from client is null.");
                return BadRequest("patchDoc object is null");
            }

            var courseEntity = _repository.Course.GetACourse(id, trackChanges: true);
            if (courseEntity == null)
            {
                _logger.LogInfo($"Course Section with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            var courseToPatch = _mapper.Map<CourseForUpdateDto>(courseEntity);

            patchDoc.ApplyTo(courseToPatch);

            _mapper.Map(courseToPatch, courseEntity);


            _repository.Save();

            return NoContent();
        }
    }
}