using System;
using System.Collections.Generic;

namespace TrainingCenterManagementSystem.Infrastructure.Data
{
    public partial class MainMenu
    {
        public MainMenu()
        {
            Menu = new HashSet<Menu>();
        }

        public int MainMenuId { get; set; }
        public string MainMenuNameEnglish { get; set; }
        public string MainMenuNameArab { get; set; }

        public virtual ICollection<Menu> Menu { get; set; }
    }
}
