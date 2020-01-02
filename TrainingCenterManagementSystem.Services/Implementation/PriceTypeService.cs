using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Services.Interfaces;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;

namespace TrainingCenterManagementSystem.Services.Implementation
{
    public class PriceTypeService : IPriceTypeService
    {
        IPriceTypesRepository priceTypesRepository;
        public PriceTypeService(IPriceTypesRepository _priceTypesRepository)
        {
            priceTypesRepository = _priceTypesRepository;
        }
        public PriceTypesDTO AddPriceType(PriceTypesDTO entity)
        {
            var priceType = priceTypesRepository.Add(entity);
            return priceType;
        }

        public void DeletePriceType(PriceTypesDTO entity)
        {
            priceTypesRepository.Delete(entity);
        }

        public List<PriceTypesDTO> GetAllPriceType()
        {
            var priceTypes = priceTypesRepository.GetAll();
            return priceTypes;
        }

        public PriceTypesDTO GetPriceTypeById(long id)
        {
           var priceType= priceTypesRepository.GetById(id);
            return priceType;
        }

        public void UpdatePriceType(PriceTypesDTO entity)
        {
            priceTypesRepository.Update(entity);
        }

    }
}
