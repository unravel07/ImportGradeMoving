using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCopyCheckPos
    {
        public Guid PosIndex { get; set; }
        public Guid PositemIndex { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public Guid? PlanGoodsIssueItemIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public decimal Qty { get; set; }
        public int? DocumentStatus { get; set; }
    }
}
