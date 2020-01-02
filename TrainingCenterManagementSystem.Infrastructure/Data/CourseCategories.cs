﻿using System;
using System.Collections.Generic;

namespace TrainingCenterManagementSystem.Infrastructure.Data
{
    public partial class CourseCategories
    {
        public CourseCategories()
        {
            Courses = new HashSet<Courses>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
    }
}
