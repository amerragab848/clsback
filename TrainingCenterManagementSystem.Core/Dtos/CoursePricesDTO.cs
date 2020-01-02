using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterManagementSystem.Core.Dtos
{
    public class CoursePricesDTO:BaseDto
    {
        public long? PriceTypeId { get; set; }
        public decimal? Price { get; set; }
        public long? CourseId { get; set; }

        public  CoursesDTO Course { get; set; }
        public  PriceTypesDTO PriceType { get; set; }
    }
}
