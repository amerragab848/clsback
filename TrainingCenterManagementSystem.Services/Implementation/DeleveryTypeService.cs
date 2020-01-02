using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;
using TrainingCenterManagementSystem.Services.Interfaces;
namespace TrainingCenterManagementSystem.Services.Implementation
{
    public class DeleveryTypeService : IDeleveryTypeService
    {
        IDeleveryTypesRepository deleveryTypesRepository;
        public DeleveryTypeService(IDeleveryTypesRepository _deleveryTypesRepository)
        {
            deleveryTypesRepository = _deleveryTypesRepository;
        }
        public DeleveryTypesDTO AddDeleveryType(DeleveryTypesDTO entity)
        {
            var deleveryType = deleveryTypesRepository.Add(entity);
            return deleveryType;
        }

        public void DeleteDeleveryType(DeleveryTypesDTO entity)
        {
            deleveryTypesRepository.Delete(entity);
        }

        public List<DeleveryTypesDTO> GetAllDeleveryTypes()
        {
          var deleveryTypes=  deleveryTypesRepository.GetAll();
            return deleveryTypes;
        }

        public DeleveryTypesDTO GetDeleveryTypeById(long id)
        {
            var deleveryType = deleveryTypesRepository.GetById(id);
            return deleveryType;
        }

        public void UpdateDeleveryType(DeleveryTypesDTO entity)
        {
            deleveryTypesRepository.Update(entity);
        }
    }
}
