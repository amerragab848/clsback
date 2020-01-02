using System;
using System.Collections.Generic;

namespace TrainingCenterManagementSystem.Infrastructure.Data
{
    public partial class LearningPathsCourses
    {
        public long Id { get; set; }
        public long? CourseId { get; set; }
        public long? LearningPathId { get; set; }

        public virtual Courses Course { get; set; }
        public virtual LearningPaths LearningPath { get; set; }
    }
}
