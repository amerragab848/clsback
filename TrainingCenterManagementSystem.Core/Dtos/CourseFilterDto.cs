using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TrainingCenterManagementSystem.Core.Dtos
{
    public class CourseFilterDto:BaseDto
    {
        public string Name { get; set; }
       
        public string CourseCategory { get; set; }
        public string CourseType { get; set; }
        public string DeliveryType { get; set; }
        public string Exam { get; set; }
        public string Lab { get; set; }
        public string Material { get; set; }
        public string Vendor { get; set; }
        public int? PagNumber { get; set; }
        public int Pagesize { get; set; }
        public string  SortOrder { get; set; }

    }
}
