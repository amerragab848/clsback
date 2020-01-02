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
    public class DeleveryTypeController : ControllerBase
    {

        private IDeleveryTypeService deleveryTypeService;
        public DeleveryTypeController(IDeleveryTypeService _deleveryTypeService)
        {
            deleveryTypeService = _deleveryTypeService;

        }
        [HttpGet]
        [Route("GetAllDeleveryTypes")]
        public async Task<ActionResult<DeleveryTypesDTO>> GetAllDeleveryTypes()
        {

            var deleveryTpes = deleveryTypeService.GetAllDeleveryTypes().ToList();
            return Ok(deleveryTpes);
        }

        // GET: api/Course/5
        [HttpGet]
        [Route("GetDeleveryType/{id}")]
        public async Task<ActionResult<DeleveryTypesDTO>> GetDeleveryType(int id)
        {
            var deleveryTpe = deleveryTypeService.GetDeleveryTypeById(id);
            return Ok(deleveryTpe);
        }

        // POST: api/Course
        [HttpPost]
        [Route("AddDeleveryType")]

        public async Task<ActionResult<DeleveryTypesDTO>> AddDeleveryType(DeleveryTypesDTO deleveryTypesDTO)
        {
            var addDeleveryType = deleveryTypeService.AddDeleveryType(deleveryTypesDTO);
            return Ok(deleveryTypesDTO);
        }

        // PUT: api/Course/5
        [HttpPost]
        [Route("UpdateDeleveryType")]
        public async Task<ActionResult> UpdateDeleveryType(DeleveryTypesDTO deleveryTypesDTO)
        {
            deleveryTypeService.UpdateDeleveryType(deleveryTypesDTO);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpPost]
        [Route("DeleteDeleveryType")]
        public async Task<ActionResult> DeleteDeleveryType(DeleveryTypesDTO deleveryTypesDTO)
        {
            deleveryTypeService.DeleteDeleveryType(deleveryTypesDTO);
            return Ok();
        }
    }
}