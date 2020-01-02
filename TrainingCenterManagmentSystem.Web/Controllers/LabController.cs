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
    [Route("api/[controller]")]
    [ApiController]
    public class LabController : ControllerBase
    {

        private ILabService labService;
        public LabController(ILabService _labService)
        {
            labService = _labService;

        }
        [HttpGet]
        [Route("GetAllLabs")]
        public async Task<ActionResult<LabsDTO>> GetAllLabs()
        {

            var courses = labService.GetAllLabs().ToList();
            return Ok(courses);
        }

        // GET: api/Course/5
        [HttpGet]
        [Route("GetLab/{id}")]
        public async Task<ActionResult<LabsDTO>> GetLab(int id)
        {
            var lab = labService.GetLabById(id);
            return Ok(lab);
        }

        // POST: api/Course
        [HttpPost]
        [Route("AddLab")]

        public async Task<ActionResult<LabsDTO>> AddLab(LabsDTO labDTO)
        {
            var addlab = labService.AddLab(labDTO);
            return Ok(labDTO);
        }

        // PUT: api/Course/5
        [HttpPost]
        [Route("UpdateLab")]
        public async Task<ActionResult> UpdateLab(LabsDTO labDTO)
        {
            labService.UpdateExam(labDTO);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpPost]
        [Route("DeleteLab")]
        public async Task<ActionResult> DeleteLab(LabsDTO labDTO)
        {
            labService.DeleteLab(labDTO);
            return Ok();
        }
    }
}