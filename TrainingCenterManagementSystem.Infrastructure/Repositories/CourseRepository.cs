using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;
using TrainingCenterManagementSystem.Infrastructure.Interfaces;
using TrainingCenterManagementSystem.Infrastructure.Data;

namespace TrainingCenterManagementSystem.Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly TMSDbContext _TMSDbContext;
        public CourseRepository(TMSDbContext dbContext) 
        {
            _TMSDbContext = dbContext;
        }
        

        public CoursesDTO Add(CoursesDTO coursesDTO)
        {
            if (coursesDTO != null)
            {
                Courses courses = new Courses
                {
                    Id = coursesDTO.Id,
                    Name = coursesDTO.Name,
                    AudienceProfileId = coursesDTO.AudienceProfileId,
                    CourseCategoryId = coursesDTO.CourseCategoryId,
                    CourseTypeId = coursesDTO.CourseTypeId,
                    DeliveryTypeId = coursesDTO.DeliveryTypeId,
                    ExamId = coursesDTO.ExamId,
                    LabId = coursesDTO.LabId,
                    MaterialId = coursesDTO.MaterialId,
                    PreRequisitesId = coursesDTO.PreRequisitesId,
                    VendorId = coursesDTO.VendorId
                };
                //  _TMSDbContext.Courses.Add(courses);
                _TMSDbContext.Add(courses);
                _TMSDbContext.SaveChanges();
            }
            return coursesDTO;
        }

        public void Delete(CoursesDTO entity)
        {
            var course = _TMSDbContext.Courses.Find(entity.Id);
            _TMSDbContext.Courses.Remove(course);
        }

        

        public CoursesDTO GetById(long id)
        {
            var course = _TMSDbContext.Courses.FirstOrDefault(c => c.Id == id);
            CoursesDTO coursesDTO = new CoursesDTO
            {
                Id= course.Id,
                Name=course.Name,
                Exam=new ExamsDTO { 
                    Name=course.Exam.Name,
                    Id = course.Exam.Id,

                },
                CourseCategory=new CourseCategoriesDTO
                {
                    Name=course.CourseCategory.Name,
                    Id=course.CourseCategory.Id
                },
                Lab=new LabsDTO
                {
                    Name = course.Lab.Name,
                    Id = course.Lab.Id
                },
                  CourseType=new PriceTypesDTO
                  {
                      Name = course.CourseType.Name,
                      Id = course.CourseType.Id
                  },
                  Material=new MaterialsDTO
                  {
                      Name = course.Material.Name,
                      Id = course.Material.Id
                  },
                  DeliveryType=new DeleveryTypesDTO
                  {
                      Name = course.DeliveryType.Name,
                      Id = course.DeliveryType.Id
                  },
                  Vendor=new VendorsDTO
                  {
                      Name = course.Vendor.Name,
                      Id = course.Vendor.Id

                  },
                 

            };
            return coursesDTO;

        }


        public int SaveChanges()
        {
          return  _TMSDbContext.SaveChanges();
        }

        public void Update(CoursesDTO entity)
        {
            var course = _TMSDbContext.Courses.FirstOrDefault(c => c.Id == entity.Id);
             course = new Courses
            {
                Id = course.Id,
                Name = course.Name,
                Exam = new Exams
                {
                    Name = entity.Exam.Name,
                    Id = entity.Exam.Id,

                },
                CourseCategory = new CourseCategories
                {
                    Name = entity.CourseCategory.Name,
                    Id = entity.CourseCategory.Id
                },
                Lab = new Labs
                {
                    Name = entity.Lab.Name,
                    Id = entity.Lab.Id
                },
                CourseType = new PriceTypes
                {
                    Name = entity.CourseType.Name,
                    Id = entity.CourseType.Id
                },
                Material = new Materials
                {
                    Name = entity.Material.Name,
                    Id = entity.Material.Id
                },
                DeliveryType = new DeleveryTypes
                {
                    Name = entity.DeliveryType.Name,
                    Id = entity.DeliveryType.Id
                },
                Vendor = new Vendors
                {
                    Name = entity.Vendor.Name,
                    Id = entity.Vendor.Id

                },


            };
            _TMSDbContext.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            SaveChanges();
        }
       public CoursesDTO FilterByName(string courseName)
        {
            var course = _TMSDbContext.Courses.FirstOrDefault(c => c.Name == courseName);
            CoursesDTO coursesDTO = new CoursesDTO
            {
                Id = course.Id,
                Name = course.Name,
                Exam = new ExamsDTO
                {
                    Name = course.Exam.Name,
                    Id = course.Exam.Id,

                },
                CourseCategory = new CourseCategoriesDTO
                {
                    Name = course.CourseCategory.Name,
                    Id = course.CourseCategory.Id
                },
                Lab = new LabsDTO
                {
                    Name = course.Lab.Name,
                    Id = course.Lab.Id
                },
                CourseType = new PriceTypesDTO
                {
                    Name = course.CourseType.Name,
                    Id = course.CourseType.Id
                },
                Material = new MaterialsDTO
                {
                    Name = course.Material.Name,
                    Id = course.Material.Id
                },
                DeliveryType = new DeleveryTypesDTO
                {
                    Name = course.DeliveryType.Name,
                    Id = course.DeliveryType.Id
                },
                Vendor = new VendorsDTO
                {
                    Name = course.Vendor.Name,
                    Id = course.Vendor.Id

                },


            };
            return coursesDTO;

        }

        public List<CoursesDTO> GetAll()
        {
            return _TMSDbContext.Courses.Select(c => new CoursesDTO
            {
                Id = c.Id,
                Name = c.Name,
                Exam = new ExamsDTO
                {
                    Name = c.Exam.Name,
                    Id = c.Exam.Id,

                },
                CourseCategory = new CourseCategoriesDTO
                {
                    Name = c.CourseCategory.Name,
                    Id = c.CourseCategory.Id
                },
                Lab = new LabsDTO
                {
                    Name = c.Lab.Name,
                    Id = c.Lab.Id
                },
                CourseType = new PriceTypesDTO
                {
                    Name = c.CourseType.Name,
                    Id = c.CourseType.Id
                },
                Material = new MaterialsDTO
                {
                    Name = c.Material.Name,
                    Id = c.Material.Id
                },
                DeliveryType = new DeleveryTypesDTO
                {
                    Name = c.DeliveryType.Name,
                    Id = c.DeliveryType.Id
                },
                Vendor = new VendorsDTO
                {
                    Name = c.Vendor.Name,
                    Id = c.Vendor.Id

                },

            }).ToList();
        }

        public IQueryable<CoursesDTO> GetAllCourses()
        {

            return _TMSDbContext.Courses.Select(c => new CoursesDTO
            {
                Id = c.Id,
                Name = c.Name,
                Exam = new ExamsDTO
                {
                    Name = c.Exam.Name,
                    Id = c.Exam.Id,

                },
                CourseCategory = new CourseCategoriesDTO
                {
                    Name = c.CourseCategory.Name,
                    Id = c.CourseCategory.Id
                },
                Lab = new LabsDTO
                {
                    Name = c.Lab.Name,
                    Id = c.Lab.Id
                },
                CourseType = new PriceTypesDTO
                {
                    Name = c.CourseType.Name,
                    Id = c.CourseType.Id
                },
                Material = new MaterialsDTO
                {
                    Name = c.Material.Name,
                    Id = c.Material.Id
                },
                DeliveryType = new DeleveryTypesDTO
                {
                    Name = c.DeliveryType.Name,
                    Id = c.DeliveryType.Id
                },
                Vendor = new VendorsDTO
                {
                    Name = c.Vendor.Name,
                    Id = c.Vendor.Id

                },

            });
        }
    }
}

