using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;
using TrainingCenterManagementSystem.Infrastructure.Repositories;
using TrainingCenterManagementSystem.Services.Interfaces;

namespace TrainingCenterManagementSystem.Services.Implementation
{
    public class LearningPathService : ILearningPathService
    {
        ILearningPathRepository learningPathRepository;
        public LearningPathService(ILearningPathRepository _learningPathRepository)
        {
            learningPathRepository = _learningPathRepository;
        }

        public LearningPathDTO AddLearningPath(LearningPathDTO entity)
        {
            if (entity != null)
            {
                learningPathRepository.Add(entity);
            }
            return entity;
        }

        public void DeleteLearningPath(LearningPathDTO entity)
        {
            learningPathRepository.Delete(entity);
        }

        public List<LearningPathDTO> GetAllLearningPath()
        {
            var learnPaths = learningPathRepository.GetAll();
            return learnPaths;
        }

        public LearningPathDTO GetLearningPathById(long id)
        {
            var learnPath = learningPathRepository.GetById(id);
            return learnPath;
        }

        public void UpdateLearningPath(LearningPathDTO entity)
        {
            learningPathRepository.Update(entity);
        }
    }
}
