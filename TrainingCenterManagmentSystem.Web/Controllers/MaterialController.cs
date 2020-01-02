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
    public class MaterialController : ControllerBase
    {

        private IMaterialService materialService;
        public MaterialController(IMaterialService _materialService)
        {
            materialService = _materialService;

        }
        [HttpGet]
        [Route("GetAllMaterials")]
        public async Task<ActionResult<MaterialsDTO>> GetAllMaterials()
        {

            var materials = materialService.GetAllMaterial().ToList();
            return Ok(materials);
        }

        // GET: api/Course/5
        [HttpGet]
        [Route("GetMaterial/{id}")]
        public async Task<ActionResult<MaterialsDTO>> GetMaterial(int id)
        {
            var material = materialService.GetMaterialById(id);
            return Ok(material);
        }

        // POST: api/Course
        [HttpPost]
        [Route("AddMaterial")]

        public async Task<ActionResult<MaterialsDTO>> AddMaterial(MaterialsDTO materialsDTO)
        {
            var addMaterial= materialService.AddMaterial(materialsDTO);
            return Ok(materialsDTO);
        }

        // PUT: api/Course/5
        [HttpPost]
        [Route("UpdateMaterial")]
        public async Task<ActionResult> UpdateMaterial(MaterialsDTO materialsDTO)
        {
            materialService.UpdateMaterial(materialsDTO);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpPost]
        [Route("DeleteMaterial")]
        public async Task<ActionResult> DeleteMaterial(MaterialsDTO materialsDTO)
        {
            materialService.DeleteMaterial(materialsDTO);
            return Ok();
        }
    }
}