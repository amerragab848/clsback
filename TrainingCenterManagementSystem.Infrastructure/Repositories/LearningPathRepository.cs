using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Infrastructure.Data;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;

namespace TrainingCenterManagementSystem.Infrastructure.Repositories
{
    public class LearningPathRepository : ILearningPathRepository
    {
       private readonly TMSDbContext _TMSDbContext;
        public LearningPathRepository(TMSDbContext TMSDbContext) 
        {
            _TMSDbContext = TMSDbContext;
        }

        public LearningPathDTO Add(LearningPathDTO entity)
        {
            if (entity != null)
            {
                LearningPaths learningPaths = new LearningPaths
                {
                    Id = entity.Id,
                    Name = entity.Name
                };
                _TMSDbContext.Add(learningPaths);
                _TMSDbContext.SaveChanges();

            }
            return entity;
        }



        public void Delete(LearningPathDTO entity)
        {
            var learningPaths = _TMSDbContext.LearningPaths.Find(entity.Id);
            _TMSDbContext.LearningPaths.Remove(learningPaths);
            SaveChanges();
        }

        public List<LearningPathDTO> GetAll()
        {
            return _TMSDbContext.LearningPaths.Select(c => new LearningPathDTO
            {
                Name = c.Name,
                Id = c.Id
            }).ToList();
        }

        public LearningPathDTO GetById(long id)
        {
            var learningPaths = _TMSDbContext.LearningPaths.Find(id);
            LearningPathDTO learningPathDTO = new LearningPathDTO
            {
                Id = learningPaths.Id,
                Name = learningPaths.Name
            };
            return learningPathDTO;
        }

       

        public int SaveChanges()
        {
           return _TMSDbContext.SaveChanges();
        }

        public void Update(LearningPathDTO entity)
        {
            var learningPaths = _TMSDbContext.LearningPaths.FirstOrDefault(c => c.Id == entity.Id);
            learningPaths = new LearningPaths
            {
                Id = entity.Id,
                Name = entity.Name

            };
            _TMSDbContext.Entry(learningPaths).State = EntityState.Modified;
        }
    }
}
