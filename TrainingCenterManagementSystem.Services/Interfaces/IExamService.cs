using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;

namespace TrainingCenterManagementSystem.Services.Interfaces
{
    public interface IExamService
    {
        ExamsDTO AddExam(ExamsDTO entity);
        void DeleteExam(ExamsDTO entity);
        ExamsDTO GetExamById(long id);
        List<ExamsDTO> GetAllExams();
        void UpdateExam(ExamsDTO entity);
    }
}
