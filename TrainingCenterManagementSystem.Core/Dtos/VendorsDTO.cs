using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterManagementSystem.Core.Dtos
{
    public class VendorsDTO:BaseDto
    {
        public string Name { get; set; }

        public  List<CoursesDTO> Courses { get; set; }
    }
}
