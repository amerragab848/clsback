using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;

namespace TrainingCenterManagementSystem.Services.Interfaces
{
   public interface IMaterialService
    {
        MaterialsDTO AddMaterial(MaterialsDTO entity);
        void DeleteMaterial(MaterialsDTO entity);
        MaterialsDTO GetMaterialById(long id);
        List<MaterialsDTO> GetAllMaterial();
        void UpdateMaterial(MaterialsDTO entity);
    }
}
