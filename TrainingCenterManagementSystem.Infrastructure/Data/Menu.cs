using System;
using System.Collections.Generic;

namespace TrainingCenterManagementSystem.Infrastructure.Data
{
    public partial class Menu
    {
        public int MenuId { get; set; }
        public string MenuNameEnglish { get; set; }
        public string MenuNameArab { get; set; }
        public int MaiMenuId { get; set; }
        public string Url { get; set; }
        public int? MenuOrder { get; set; }
        public string MenuIcon { get; set; }
        public int? LoadOnOpening { get; set; }

        public virtual MainMenu MaiMenu { get; set; }
        public virtual RoleMenu RoleMenu { get; set; }
    }
}
