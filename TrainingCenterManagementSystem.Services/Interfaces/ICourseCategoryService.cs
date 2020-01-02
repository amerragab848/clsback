using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;

namespace TrainingCenterManagementSystem.Services.Interfaces
{
    public interface ICourseCategoryService
    {
        CourseCategoriesDTO AddCourseCategories(CourseCategoriesDTO entity);
        void DeleteCourseCategories(CourseCategoriesDTO entity);
        CourseCategoriesDTO GetCourseCategoriesById(long id);
        List<CourseCategoriesDTO> GetAllCourseCategories();
        void UpdateCourseCategories(CourseCategoriesDTO entity);
    }
}
