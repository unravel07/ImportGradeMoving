using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewDiscount
    {
        public Guid PlanGoodsIssueItemIndex { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public string Discount { get; set; }
    }
}
