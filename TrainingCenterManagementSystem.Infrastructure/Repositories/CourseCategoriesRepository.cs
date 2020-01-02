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
    public class CourseCategoriesRepository : ICourseCategoriesRepository
    {
        private readonly TMSDbContext _TMSDbContext;
        public CourseCategoriesRepository(TMSDbContext dbContext)
        {
            _TMSDbContext = dbContext;
        }
        public CourseCategoriesDTO Add(CourseCategoriesDTO entity)
        {
            CourseCategories courseCategories = new CourseCategories
            {
                Id = entity.Id,
                Name = entity.Name
            };
            _TMSDbContext.CourseCategories.Add(courseCategories);
            SaveChanges();
            return entity;
        }

        public void Delete(CourseCategoriesDTO entity)
        {
            var CourseCategorie = _TMSDbContext.CourseCategories.Find(entity.Id);
            _TMSDbContext.CourseCategories.Remove(CourseCategorie);
            SaveChanges();
        }

        public List<CourseCategoriesDTO> GetAll()
        {
            return _TMSDbContext.CourseCategories.Select(c => new CourseCategoriesDTO
            {
                Name = c.Name,
                Id = c.Id
            }).ToList();
        }

        public CourseCategoriesDTO GetById(long id)
        {
            var courseCategory = _TMSDbContext.CourseCategories.Find(id);
            CourseCategoriesDTO courseCategoriesDTO = new CourseCategoriesDTO
            {
                Id = courseCategory.Id,
                Name = courseCategory.Name
            };
            return courseCategoriesDTO;
        }

        

        public int SaveChanges()
        {
           return _TMSDbContext.SaveChanges();
        }

        public void Update(CourseCategoriesDTO entity)
        {
            var courseCategories = _TMSDbContext.CourseCategories.FirstOrDefault(c=>c.Id==entity.Id);
             courseCategories = new CourseCategories
            {
                Id = entity.Id,
                Name=entity.Name

            };
            _TMSDbContext.Entry(courseCategories).State = EntityState.Modified;

        }
    }
}
