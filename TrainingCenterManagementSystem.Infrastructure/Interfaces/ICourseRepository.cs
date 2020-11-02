using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Infrastructure.Data;

namespace TrainingCenterManagementSystem.Infrastructure.Interfaces
{
    public interface ICourseRepository :IRepository<CoursesDTO>
    {
        CoursesDTO FilterByName(string courseName);
        IQueryable<CoursesDTO> GetAllCourses();
    }
}
