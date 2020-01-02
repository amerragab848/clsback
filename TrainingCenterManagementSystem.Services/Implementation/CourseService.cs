using System;
using System.Collections.Generic;
using System.Linq;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;
using TrainingCenterManagementSystem.Services.Interfaces;

namespace TrainingCenterManagementSystem.Services.Implementation
{
    public class CourseService :ICourseService
    {
        ICourseRepository repository;
        public CourseService(ICourseRepository  _repository)
        {
            repository = _repository;
        }


        public CoursesDTO AddCourse(CoursesDTO entity)
        {
            if (entity != null)
                repository.Add(entity);
            return entity;
        }


        public void DeleteCourse(CoursesDTO entity)
        {
            if (entity != null)
                repository.Delete(entity);
        }

        public CoursesDTO FilterByName(string courseName)
        {
          var course=  repository.FilterByName(courseName);
            return course;
        }

        public List<CoursesDTO> GetAllCourse()
        {
            var courses = repository.GetAll();
            return courses;
        }

      

        public CoursesDTO GetCourseById(long id)
        {
            var course = repository.GetById(id);
            return course;
        }
        public void UpdateCourse(CoursesDTO entity)
        {
            if (entity != null)
                repository.Update(entity);
        }


    }
}
