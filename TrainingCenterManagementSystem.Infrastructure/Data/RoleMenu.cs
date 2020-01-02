using System;
using System.Collections.Generic;

namespace TrainingCenterManagementSystem.Infrastructure.Data
{
    public partial class RoleMenu
    {
        public int RoleMenuId { get; set; }
        public int RoleId { get; set; }
        public string MenuId { get; set; }

        public virtual Menu RoleMenuNavigation { get; set; }
    }
}
