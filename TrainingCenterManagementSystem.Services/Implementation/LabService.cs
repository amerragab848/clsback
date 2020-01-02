using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Services.Interfaces;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;

namespace TrainingCenterManagementSystem.Services.Implementation
{
    public class LabService : ILabService
    {
        ILabsRepository labsRepository;
        public LabService(ILabsRepository _labsRepository)
        {
            labsRepository = _labsRepository;
        }
        public LabsDTO AddLab(LabsDTO entity)
        {
           var lab= labsRepository.Add(entity);
            return lab;
        }

        public void DeleteLab(LabsDTO entity)
        {
            labsRepository.Delete(entity);
        }

        public List<LabsDTO> GetAllLabs()
        {
          var labs=  labsRepository.GetAll();
            return labs;
        }

        public LabsDTO GetLabById(long id)
        {
            var lab = labsRepository.GetById(id);
            return lab;
        }

        public void UpdateExam(LabsDTO entity)
        {
            labsRepository.Update(entity);
        }
    }
}
