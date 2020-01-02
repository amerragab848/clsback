using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterManagementSystem.Core.Dtos
{
    public class LearningPathDTO:BaseDto
    {
        public string Name { get; set; }

        public  List<LearningPathsCoursesDTO> LearningPathsCourses { get; set; }
    }
}
