using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Services.Interfaces;

namespace TrainingCenterManagmentSystem.Web.Controllers
{
    [Route("api/CourseCategory")]
    [ApiController]
    public class CourseCategoryController : ControllerBase
    {
        private ICourseCategoryService courseCategory;
        public CourseCategoryController(ICourseCategoryService _courseCategory)
        {
            courseCategory = _courseCategory;

        }
        [HttpGet]
        [Route("GetAllCourseCategories")]
        public async Task<ActionResult<CourseCategoriesDTO>> GetAllCourseCategories()
        {

            var courses = courseCategory.GetAllCourseCategories().ToList();
            return Ok(courses);
        }

        // GET: api/Course/5
        [HttpGet]
        [Route("GetCourseCategory/{id}")]
        public async Task<ActionResult<CourseCategoriesDTO>> GetCourseCategory(int id)
        {
            var exm = courseCategory.GetCourseCategoriesById(id);
            return Ok(exm);
        }

        // POST: api/Course
        [HttpPost]
        [Route("AddCourseCategory")]

        public async Task<ActionResult<CourseCategoriesDTO>> AddCourseCategory(CourseCategoriesDTO courseCategoriesDTO)
        {
            var addexm = courseCategory.AddCourseCategories(courseCategoriesDTO);
            return Ok(courseCategoriesDTO);
        }

        // PUT: api/Course/5
        [HttpPost]
        [Route("UpdateCourseCategory")]
        public async Task<ActionResult> UpdateCourseCategory(CourseCategoriesDTO courseCategoriesDTO)
        {
            courseCategory.UpdateCourseCategories(courseCategoriesDTO);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpPost]
        [Route("DeleteCourseCategory")]
        public async Task<ActionResult> DeleteCourseCategory(CourseCategoriesDTO courseCategoriesDTO)
        {
            courseCategory.DeleteCourseCategories(courseCategoriesDTO);
            return Ok();
        }
    }
}