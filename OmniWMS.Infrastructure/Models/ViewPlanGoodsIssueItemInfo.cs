using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPlanGoodsIssueItemInfo
    {
        public long? RowIndex { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public Guid? PlanGoodsIssueItemIndex { get; set; }
        public decimal? QtyOrder { get; set; }
        public decimal? QtyCancelled { get; set; }
        public decimal Qty { get; set; }
        public decimal QtyBackOrder { get; set; }
        public decimal Count { get; set; }
        public int PluStatus { get; set; }
    }
}
