using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Services.Interfaces;

namespace TrainingCenterManagmentSystem.Web.Controllers
{
    [Route("api/Course")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        // GET: api/Course
        private ICourseService course;
        public CourseController(ICourseService _course)
        {
            course = _course;

        }
        [HttpGet]
        [Route("GetAllCourses")]
        public async Task<ActionResult<CoursesDTO>> GetAllCourses()
        {
             
           var courses= course.GetAllCourse().ToList();
            return Ok( courses);
        }
        [HttpPost]
        [Route("GetAllCoursesPaging")]
        public async Task<ActionResult<CoursesDTO>> GetAllCourses(int pageNumber,int pageSize)
        {

            var courses = course.GetAllCourse(pageNumber, pageSize).ToList();
            return Ok(courses);
        }
        [HttpPost]
        [Route("CoursesFilter")]
        public async Task<ActionResult<CoursesDTO>> GetAllCourses(CourseFilterDto coursesDTO)
        {

            var courses = course.FilterCoursesAsync(coursesDTO);
            return Ok(courses);
        }
        // GET: api/Course/5
        [HttpGet]
        [Route("GetCourse/{id}")]

        public async Task<ActionResult<CoursesDTO>> GetCourse(int id)
        {
            var crs = course.GetCourseById(id);
            return Ok(crs); 
        }

        // POST: api/Course
        [HttpPost]
        [Route("AddCourse")]
        public async Task<ActionResult<CoursesDTO>> AddCourse(CoursesDTO courseDTo)
        {
           var addCrs=  course.AddCourse(courseDTo);
            return Ok(addCrs);
        }

        // PUT: api/Course/5
        [HttpPost]
        [Route("UpdateCourse")]
        public async Task<ActionResult> UpdateCourse(CoursesDTO courseDTo)
        {
            course.UpdateCourse(courseDTo);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpPost]
        [Route("DeleteCourse")]
        public async Task<ActionResult> DeleteCourse(CoursesDTO courseDTo)
        {
            course.UpdateCourse(courseDTo);
            return Ok();
        }
    }
}
