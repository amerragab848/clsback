using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterManagementSystem.Core.Dtos
{
    public class CoursesDTO:BaseDto
    {
        public string Name { get; set; }
        public long? CourseCategoryId { get; set; }
        public long? CourseTypeId { get; set; }
        public long? VendorId { get; set; }
        public long? DeliveryTypeId { get; set; }
        public long? AudienceProfileId { get; set; }
        public long? PreRequisitesId { get; set; }
        public long? ExamId { get; set; }
        public long? MaterialId { get; set; }
        public long? LabId { get; set; }
        public  CourseCategoriesDTO CourseCategory { get; set; }
        public  PriceTypesDTO CourseType { get; set; }
        public  DeleveryTypesDTO DeliveryType { get; set; }
        public  ExamsDTO Exam { get; set; }
        public  LabsDTO Lab { get; set; }
        public  MaterialsDTO Material { get; set; }
        public  VendorsDTO Vendor { get; set; }
        public  List<CoursePricesDTO> CoursePrices { get; set; }
        public  List<LearningPathsCoursesDTO> LearningPathsCourses { get; set; }
    }
}
