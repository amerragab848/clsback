using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;

namespace TrainingCenterManagementSystem.Services.Interfaces
{
    public interface IDeleveryTypeService
    {
        DeleveryTypesDTO AddDeleveryType(DeleveryTypesDTO entity);
        void DeleteDeleveryType(DeleveryTypesDTO entity);
        DeleveryTypesDTO GetDeleveryTypeById(long id);
        List<DeleveryTypesDTO> GetAllDeleveryTypes();
        void UpdateDeleveryType(DeleveryTypesDTO entity);
    }
}
