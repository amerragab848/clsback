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
         System.Threading.Tasks.Task< List<CoursesDTO>> FilterCoursesAsync(CourseFilterDto coursesDTO);
        List<CoursesDTO> GetAllCourse(int pageNumber,int pageSize);
        CoursesDTO AddCourse(CoursesDTO entity);
        void UpdateCourse(CoursesDTO entity);
        void DeleteCourse(CoursesDTO entity);
        CoursesDTO FilterByName(string courseName);
    }
}
