using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;

namespace TrainingCenterManagementSystem.Services.Interfaces
{
    public interface ICourseService
    {
        CoursesDTO GetCourseById(long id);
        List<CoursesDTO> GetAllCourse();
        CoursesDTO AddCourse(CoursesDTO entity);
        void UpdateCourse(CoursesDTO entity);
        void DeleteCourse(CoursesDTO entity);
        CoursesDTO FilterByName(string courseName);
    }
}
