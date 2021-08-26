using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImDiscounts
    {
        public Guid DiscountsIndex { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public Guid PlanGoodsIssueItemIndex { get; set; }
        public string DiscountsType { get; set; }
        public string DiscountsBarcode { get; set; }
        public decimal? DiscountsAmount { get; set; }
    }
}
