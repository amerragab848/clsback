using System;
using System.Collections.Generic;

namespace TrainingCenterManagementSystem.Infrastructure.Data
{
    public partial class DeleveryTypes
    {
        public DeleveryTypes()
        {
            Courses = new HashSet<Courses>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
    }
}
