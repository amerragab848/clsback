using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Services.Interfaces;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;

namespace TrainingCenterManagementSystem.Services.Implementation
{
    public class MaterialService : IMaterialService
    {
        IMaterialsRepository materialsRepository;
        public MaterialService(IMaterialsRepository _materialsRepository)
        {
            materialsRepository = _materialsRepository;
        }
        public MaterialsDTO AddMaterial(MaterialsDTO entity)
        {
           var material= materialsRepository.Add(entity);
            return material;
        }

        public void DeleteMaterial(MaterialsDTO entity)
        {
            materialsRepository.Delete(entity);
        }

        public List<MaterialsDTO> GetAllMaterial()
        {
            var materials = materialsRepository.GetAll();
            return materials;
        }

        public MaterialsDTO GetMaterialById(long id)
        {
            var material = materialsRepository.GetById(id);
            return material;
        }

        public void UpdateMaterial(MaterialsDTO entity)
        {
            materialsRepository.Update(entity);
        }
    }
}
