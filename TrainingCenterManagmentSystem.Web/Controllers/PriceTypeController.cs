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
    public class PriceTypeController : ControllerBase
    {

        private IPriceTypeService priceTypeService;
        public PriceTypeController(IPriceTypeService _priceTypeService)
        {
            priceTypeService = _priceTypeService;

        }
        [HttpGet]
        [Route("GetAllPriceTypes")]
        public async Task<ActionResult<PriceTypesDTO>> GetAllPriceTypes()
        {

            var priceTypes = priceTypeService.GetAllPriceType().ToList();
            return Ok(priceTypes);
        }

        // GET: api/Course/5
        [HttpGet]
        [Route("GetPriceType/{id}")]
        public async Task<ActionResult<PriceTypesDTO>> GetPriceType(int id)
        {
            var pricetype = priceTypeService.GetPriceTypeById(id);
            return Ok(pricetype);
        }

        // POST: api/Course
        [HttpPost]
        [Route("AddPriceType")]

        public async Task<ActionResult<PriceTypesDTO>> AddPriceType(PriceTypesDTO PriceTypesDTO)
        {
            var addPriceType = priceTypeService.AddPriceType(PriceTypesDTO);
            return Ok(PriceTypesDTO);
        }

        // PUT: api/Course/5
        [HttpPost]
        [Route("UpdatePriceType")]
        public async Task<ActionResult> UpdatePriceType(PriceTypesDTO PriceTypesDTO)
        {
            priceTypeService.UpdatePriceType(PriceTypesDTO);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpPost]
        [Route("DeletePriceType")]
        public async Task<ActionResult> DeletePriceType(PriceTypesDTO PriceTypesDTO)
        {
            priceTypeService.DeletePriceType(PriceTypesDTO);
            return Ok();
        }
    }
}