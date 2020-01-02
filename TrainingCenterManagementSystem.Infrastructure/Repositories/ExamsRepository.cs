using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;
using TrainingCenterManagementSystem.Infrastructure.Data;

namespace TrainingCenterManagementSystem.Infrastructure.Repositories
{
    public class ExamsRepository: IExamRepository
    {
        private readonly TMSDbContext _TMSDbContext;
        public ExamsRepository(TMSDbContext dbContext)
        {
            _TMSDbContext = dbContext;
        }
        public ExamsDTO Add(ExamsDTO entity)
        {
            Exams exams = new Exams
            {
                Id = entity.Id,
                Name = entity.Name
            };
            _TMSDbContext.Exams.Add(exams);
            SaveChanges();
            return entity;
        }

        public void Delete(ExamsDTO entity)
        {
            var exams = _TMSDbContext.Exams.Find(entity.Id);
            _TMSDbContext.Exams.Remove(exams);
            SaveChanges();
        }

        public List<ExamsDTO> GetAll()
        {
            return _TMSDbContext.Exams.Select(c => new ExamsDTO
            {
                Name = c.Name,
                Id = c.Id
            }).ToList();
        }

        public ExamsDTO GetById(long id)
        {
            var courseCategory = _TMSDbContext.Exams.Find(id);
            ExamsDTO examsDTO = new ExamsDTO
            {
                Id = courseCategory.Id,
                Name = courseCategory.Name
            };
            return examsDTO;
        }

        public int SaveChanges()
        {
            return _TMSDbContext.SaveChanges();
        }

        public void Update(ExamsDTO entity)
        {
            var exams = _TMSDbContext.Exams.FirstOrDefault(c => c.Id == entity.Id);
            exams = new Exams
            {
                Id = entity.Id,
                Name = entity.Name

            };
            _TMSDbContext.Entry(exams).State = EntityState.Modified;

        }
    }
}
