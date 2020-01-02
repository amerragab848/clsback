using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;
using TrainingCenterManagementSystem.Services.Interfaces;

namespace TrainingCenterManagementSystem.Services.Implementation
{
    public class CourseCategoryService : ICourseCategoryService
    {
        ICourseCategoriesRepository courseCategoriesRepository;
        public CourseCategoryService(ICourseCategoriesRepository _courseCategoriesRepository)
        {
            courseCategoriesRepository = _courseCategoriesRepository;
        }
        public CourseCategoriesDTO AddCourseCategories(CourseCategoriesDTO entity)
        {
          
            var courseCat = courseCategoriesRepository.Add(entity);
            return courseCat;
        }

        public void DeleteCourseCategories(CourseCategoriesDTO entity)
        {
            courseCategoriesRepository.Delete(entity);
        }

        public List<CourseCategoriesDTO> GetAllCourseCategories()
        {
            var courseCat = courseCategoriesRepository.GetAll();
            return courseCat;
        }

        public CourseCategoriesDTO GetCourseCategoriesById(long id)
        {
            var courseCat = courseCategoriesRepository.GetById(id);
            return courseCat;
        }

        public void UpdateCourseCategories(CourseCategoriesDTO entity)
        {
            courseCategoriesRepository.Update(entity);
        }
    }
}
