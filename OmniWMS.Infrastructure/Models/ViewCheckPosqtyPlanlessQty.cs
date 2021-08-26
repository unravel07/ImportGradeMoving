using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCheckPosqtyPlanlessQty
    {
        public Guid PosIndex { get; set; }
        public string ProductId { get; set; }
        public decimal? QtyPlan { get; set; }
        public decimal Qty { get; set; }
        public decimal Ratio { get; set; }
        public decimal TotalQty { get; set; }
        public string Udf5 { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public Guid? PlanGoodsIssueItemIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public Guid PositemIndex { get; set; }
    }
}
