using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;
using TrainingCenterManagementSystem.Services.Interfaces;

namespace TrainingCenterManagmentSystem.Web.Controllers
{
    [Route("api/Exam")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private IExamService exam;
        public ExamController(IExamService _exam)
        {
            exam = _exam;

        }
        [HttpGet]
        [Route("GetAllExams")]
        public async Task<ActionResult<ExamsDTO>> GetAllExams()
        {

            var courses = exam.GetAllExams().ToList();
            return Ok(courses);
        }

        // GET: api/Course/5
        [HttpGet]
        [Route("GetExam/{id}")]
        public async Task<ActionResult<ExamsDTO>> GetExam(int id)
        {
            var exm = exam.GetExamById(id);
            return Ok(exm);
        }

        // POST: api/Course
        [HttpPost]
        [Route("AddExam")]

        public async Task<ActionResult<ExamsDTO>> AddExam(ExamsDTO examsDTO)
        {
            var addexm = exam.AddExam(examsDTO);
            return Ok(examsDTO);
        }

        // PUT: api/Course/5
        [HttpPost]
        [Route("UpdateExam")]
        public async Task<ActionResult> UpdateExam(ExamsDTO examsDTO)
        {
            exam.UpdateExam(examsDTO);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpPost]
        [Route("DeleteExam")]
        public async Task<ActionResult> DeleteExam(ExamsDTO examsDTO)
        {
            exam.DeleteExam(examsDTO);
            return Ok();
        }
    }
}