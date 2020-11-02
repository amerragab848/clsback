using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Infrastructure.Data;
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

        public List<CoursesDTO> FilterCoursesAsync(CourseFilterDto coursesDTO)
        {
           // coursesDTO.Vendor = "vendor1";
            IEnumerable<CoursesDTO> query= new List<CoursesDTO>() ;
            if (!string.IsNullOrEmpty(coursesDTO.Name) )  
            {
                query= repository.GetAllCourses().Where(c => c.Name.ToLower().Contains(coursesDTO.Name)) ;
               
            }
            if (!string.IsNullOrEmpty(coursesDTO.Vendor)&& !string.IsNullOrEmpty(coursesDTO.Name))
            {
                query = repository.GetAllCourses().Where(c => c.Vendor.Name.ToLower().Contains(coursesDTO.Vendor.ToLower())
                &&  c.Name.ToLower().Contains(coursesDTO.Name)).ToList();
            }
            if (!string.IsNullOrEmpty(coursesDTO.Material)&& !string.IsNullOrEmpty(coursesDTO.Vendor) 
                && !string.IsNullOrEmpty(coursesDTO.Name))
            {
                query = repository.GetAllCourses().Where(c => c.Material.Name.ToLower().Contains(coursesDTO.Material.ToLower())&&
                 c.Vendor.Name.ToLower().Contains(coursesDTO.Vendor.ToLower())
                && c.Name.ToLower().Contains(coursesDTO.Name)).ToList();
            }
            if (!string.IsNullOrEmpty(coursesDTO.Exam)&& !string.IsNullOrEmpty(coursesDTO.Material) && !string.IsNullOrEmpty(coursesDTO.Vendor)
                && !string.IsNullOrEmpty(coursesDTO.Name))
            {
                query = repository.GetAllCourses().Where(c => c.Exam.Name.ToLower().Contains(coursesDTO.Exam.ToLower())&&
                c.Material.Name.ToLower().Contains(coursesDTO.Material.ToLower()) &&
                 c.Vendor.Name.ToLower().Contains(coursesDTO.Vendor.ToLower())
                && c.Name.ToLower().Contains(coursesDTO.Name)).ToList();
            }
            if (!string.IsNullOrEmpty(coursesDTO.DeliveryType)&& !string.IsNullOrEmpty(coursesDTO.Exam) && !string.IsNullOrEmpty(coursesDTO.Material) && !string.IsNullOrEmpty(coursesDTO.Vendor)
                && !string.IsNullOrEmpty(coursesDTO.Name))
            {
                query = repository.GetAllCourses().Where(c => c.DeliveryType.Name.ToLower().Contains(coursesDTO.DeliveryType.ToLower())&&
                c.Exam.Name.ToLower().Contains(coursesDTO.Exam.ToLower()) &&
                c.Material.Name.ToLower().Contains(coursesDTO.Material.ToLower()) &&
                 c.Vendor.Name.ToLower().Contains(coursesDTO.Vendor.ToLower())
                && c.Name.ToLower().Contains(coursesDTO.Name)).ToList();
            }
            if (!string.IsNullOrEmpty(coursesDTO.Lab)&& !string.IsNullOrEmpty(coursesDTO.DeliveryType) && !string.IsNullOrEmpty(coursesDTO.Exam) && !string.IsNullOrEmpty(coursesDTO.Material) && !string.IsNullOrEmpty(coursesDTO.Vendor)
                && !string.IsNullOrEmpty(coursesDTO.Name))
            {
                query = repository.GetAllCourses().Where(c => c.Lab.Name.ToLower().Contains(coursesDTO.Lab.ToLower())&&
                 c.DeliveryType.Name.ToLower().Contains(coursesDTO.DeliveryType.ToLower()) &&
                c.Exam.Name.ToLower().Contains(coursesDTO.Exam.ToLower()) &&
                c.Material.Name.ToLower().Contains(coursesDTO.Material.ToLower()) &&
                 c.Vendor.Name.ToLower().Contains(coursesDTO.Vendor.ToLower())
                && c.Name.ToLower().Contains(coursesDTO.Name)).ToList();
            }





            switch (coursesDTO.SortOrder)
            {
                case "Lab":
                    query.OrderByDescending(s => s.Name).ToList();
                    break;
                case "Vendor":
                    query.OrderByDescending(s => s.Vendor.Name).ToList();
                    break;
                case "Material":
                    query.OrderByDescending(s => s.Material.Name).ToList();
                    break;
                case "Exam":
                    query.OrderByDescending(s => s.Exam.Name).ToList();
                    break;
                case "DeliveryType":
                    query.OrderByDescending(s => s.DeliveryType.Name).ToList();
                    break;
                default:
                    query.OrderByDescending(s => s.Name).ToList();
                    break;
            }
            int count = query.Count();
            var res =  PaginatedList<CoursesDTO>.Create(query.AsQueryable().AsNoTracking(), coursesDTO.PagNumber ?? 1, coursesDTO.Pagesize);


            return res;
        }

        public List<CoursesDTO> GetAllCourse()
        {
            var courses = repository.GetAll();
            return courses.ToList();
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
