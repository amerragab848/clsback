using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;

namespace TrainingCenterManagementSystem.Services.Interfaces
{
    public interface ILearningPathService
    {
        LearningPathDTO AddLearningPath(LearningPathDTO entity);
        void DeleteLearningPath(LearningPathDTO entity);
        LearningPathDTO GetLearningPathById(long id);
        List<LearningPathDTO> GetAllLearningPath();
        void UpdateLearningPath(LearningPathDTO entity);
    }
}
