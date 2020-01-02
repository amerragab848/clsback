using System;
using System.Collections.Generic;

namespace TrainingCenterManagementSystem.Infrastructure.Data
{
    public partial class OffersCategory
    {
        public OffersCategory()
        {
            Offers = new HashSet<Offers>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Offers> Offers { get; set; }
    }
}
