using System;
using System.Collections.Generic;

namespace TrainingCenterManagementSystem.Infrastructure.Data
{
    public partial class PriceTypes
    {
        public PriceTypes()
        {
            CoursePrices = new HashSet<CoursePrices>();
            Courses = new HashSet<Courses>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CoursePrices> CoursePrices { get; set; }
        public virtual ICollection<Courses> Courses { get; set; }
    }
}
