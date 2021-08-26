using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCheckQtyPick
    {
        public Guid PlanGoodsIssueItemIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string LineNum { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal OrderQty { get; set; }
        public decimal PickingQty { get; set; }
        public decimal QtyBackOrder { get; set; }
        public decimal MarshallTaskPick { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public int ReplaceStatus { get; set; }
        public decimal? WeightTotal { get; set; }
        public decimal? ShipQty { get; set; }
        public decimal QtyRemark { get; set; }
    }
}
