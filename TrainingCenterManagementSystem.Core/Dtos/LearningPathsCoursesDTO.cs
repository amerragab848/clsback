using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterManagementSystem.Core.Dtos
{
    public class LearningPathsCoursesDTO
    {
        public long Id { get; set; }
        public long? CourseId { get; set; }
        public long? LearningPathId { get; set; }

        public  CoursesDTO Course { get; set; }
        public  LearningPathDTO LearningPath { get; set; }
    }
}
