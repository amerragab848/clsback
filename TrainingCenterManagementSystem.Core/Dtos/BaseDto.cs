using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingCenterManagementSystem.Core.Dtos
{
    public class BaseDto
    {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
