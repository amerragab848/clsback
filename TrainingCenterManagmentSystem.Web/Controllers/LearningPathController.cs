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
    [Route("api/LearningPath")]
    [ApiController]
    public class LearningPathController : ControllerBase
    {
        private ILearningPathService learningPathService;
        public LearningPathController(ILearningPathService _learningPathService)
        {
            learningPathService = _learningPathService;

        }
        [HttpGet]
        [Route("GetAllLearningPaths")]
        public async Task<ActionResult<LearningPathDTO>> GetAllLearningPaths()
        {

            var learningPaths = learningPathService.GetAllLearningPath().ToList();
            return Ok(learningPaths);
        }

        // GET: api/Course/5
        [HttpGet]
        [Route("GetLearningPaths/{id}")]
        public async Task<ActionResult<LearningPathDTO>> GetLearningPaths(int id)
        {
            var learningPath = learningPathService.GetLearningPathById(id);
            return Ok(learningPath);
        }

        // POST: api/Course
        [HttpPost]
        [Route("AddLearningPath")]

        public async Task<ActionResult<LearningPathDTO>> AddLearningPath(LearningPathDTO LearningPathDTO)
        {
            var addLearningPath = learningPathService.AddLearningPath(LearningPathDTO);
            return Ok(LearningPathDTO);
        }

        // PUT: api/Course/5
        [HttpPost]
        [Route("UpdateLearningPath")]
        public async Task<ActionResult> UpdateLearningPath(LearningPathDTO LearningPathDTO)
        {
            learningPathService.UpdateLearningPath(LearningPathDTO);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpPost]
        [Route("DeleteLearningPath")]
        public async Task<ActionResult> DeleteLearningPath(LearningPathDTO LearningPathDTO)
        {
            learningPathService.DeleteLearningPath(LearningPathDTO);
            return Ok();
        }
    }
}