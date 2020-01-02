using System;
using System.Collections.Generic;

namespace TrainingCenterManagementSystem.Infrastructure.Data
{
    public partial class Courses
    {
        public Courses()
        {
            CoursePrices = new HashSet<CoursePrices>();
            LearningPathsCourses = new HashSet<LearningPathsCourses>();
        }

        public long Id { get; set; }
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

        public virtual CourseCategories CourseCategory { get; set; }
        public virtual PriceTypes CourseType { get; set; }
        public virtual DeleveryTypes DeliveryType { get; set; }
        public virtual Exams Exam { get; set; }
        public virtual Labs Lab { get; set; }
        public virtual Materials Material { get; set; }
        public virtual Vendors Vendor { get; set; }
        public virtual ICollection<CoursePrices> CoursePrices { get; set; }
        public virtual ICollection<LearningPathsCourses> LearningPathsCourses { get; set; }
    }
}
