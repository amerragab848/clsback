using System;
using System.Collections.Generic;

namespace TrainingCenterManagementSystem.Infrastructure.Data
{
    public partial class LearningPaths
    {
        public LearningPaths()
        {
            LearningPathsCourses = new HashSet<LearningPathsCourses>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<LearningPathsCourses> LearningPathsCourses { get; set; }
    }
}
