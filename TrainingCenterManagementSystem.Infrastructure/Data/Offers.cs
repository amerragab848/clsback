using System;
using System.Collections.Generic;

namespace TrainingCenterManagementSystem.Infrastructure.Data
{
    public partial class Offers
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? OfferCatgeoryId { get; set; }

        public virtual OffersCategory OfferCatgeory { get; set; }
    }
}
