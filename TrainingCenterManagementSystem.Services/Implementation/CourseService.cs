using Microsoft.EntityFrameworkCore;
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

        public async System.Threading.Tasks.Task<List<CoursesDTO>> FilterCoursesAsync(CourseFilterDto coursesDTO)
        {
            var course = repository.GetAll().AsQueryable();

            if (!string.IsNullOrEmpty(coursesDTO.Name) || !string.IsNullOrEmpty(coursesDTO.Vendor) || !string.IsNullOrEmpty(coursesDTO.Material) 
                || !string.IsNullOrEmpty(coursesDTO.Exam) || !string.IsNullOrEmpty(coursesDTO.DeliveryType) || !string.IsNullOrEmpty(coursesDTO.Lab))
            {
                course.Where(c => c.Name.Contains(coursesDTO.Name) || c.Vendor.Name.Contains(coursesDTO.Vendor)

            || c.Material.Name.Contains(coursesDTO.Material) || c.Exam.Name.Contains(coursesDTO.Exam) || c.DeliveryType.Name.Contains(coursesDTO.DeliveryType)
            || c.Lab.Name.Contains(coursesDTO.Lab));
            }

            switch (coursesDTO.SortOrder)
            {
                case "Lab":
                    course = course.OrderByDescending(s => s.Name);
                    break;
                case "Vendor":
                    course = course.OrderByDescending(s => s.Vendor.Name);
                    break;
                case "Material":
                    course = course.OrderByDescending(s => s.Material.Name);
                    break;
                case "Exam":
                    course = course.OrderByDescending(s => s.Exam.Name);
                    break;
                case "DeliveryType":
                    course = course.OrderByDescending(s => s.DeliveryType.Name);
                    break;
                default:
                    course = course.OrderByDescending(s => s.Name);
                    break;
            }
            int count = course.Count();
            var res = await PaginatedList<CoursesDTO>.CreateAsync(course.AsNoTracking(), coursesDTO.PagNumber ?? 1, coursesDTO.Pagesize);


            return res;
        }

        public List<CoursesDTO> GetAllCourse()
        {
            var courses = repository.GetAll();
            return courses;
        }

        public List<CoursesDTO> GetAllCourse(int pageNumber, int pageSize)
        {
            var courses = repository.GetAll().OrderByDescending(c=>c.Id).Skip(pageSize*pageNumber).Take(pageSize).ToList();
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
