using System;
using System.Collections.Generic;

namespace TrainingCenterManagementSystem.Infrastructure.Data
{
    public partial class CoursePrices
    {
        public long Id { get; set; }
        public long? PriceTypeId { get; set; }
        public decimal? Price { get; set; }
        public long? CourseId { get; set; }

        public virtual Courses Course { get; set; }
        public virtual PriceTypes PriceType { get; set; }
    }
}
