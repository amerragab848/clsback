using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterManagementSystem.Core.Dtos
{
    public class PriceTypesDTO:BaseDto
    {
        public string Name { get; set; }

        public  List<CoursePricesDTO> CoursePrices { get; set; }
        public  List<CoursesDTO> Courses { get; set; }
    }
}
