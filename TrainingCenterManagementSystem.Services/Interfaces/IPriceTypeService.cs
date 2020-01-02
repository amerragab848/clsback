using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;

namespace TrainingCenterManagementSystem.Services.Interfaces
{
    public interface IPriceTypeService
    {
        PriceTypesDTO AddPriceType(PriceTypesDTO entity);
        void DeletePriceType(PriceTypesDTO entity);
        PriceTypesDTO GetPriceTypeById(long id);
        List<PriceTypesDTO> GetAllPriceType();
        void UpdatePriceType(PriceTypesDTO entity);
    }
}
