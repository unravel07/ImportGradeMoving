using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImDelivery
    {
        public Guid DeliveryIndex { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public string DeliveryBarcode { get; set; }
        public decimal? DeliveryAmount { get; set; }
    }
}
