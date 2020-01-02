using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;

namespace TrainingCenterManagementSystem.Services.Interfaces
{
   public interface ILabService
    {
        LabsDTO AddLab(LabsDTO entity);
        void DeleteLab(LabsDTO entity);
        LabsDTO GetLabById(long id);
        List<LabsDTO> GetAllLabs();
        void UpdateExam(LabsDTO entity);
    }
}
