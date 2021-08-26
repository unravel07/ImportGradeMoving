using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewShippmentDispatchProductV2
    {
        public long? RowIndex { get; set; }
        public string TruckLoadNo { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Ratio { get; set; }
        public decimal? TotalQty { get; set; }
        public decimal? QtyBackOrder { get; set; }
        public int ReplaceStatus { get; set; }
        public decimal? PickingQty { get; set; }
        public decimal? MarshallTaskPick { get; set; }
        public Guid? TruckLoadIndex { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public Guid PlanGoodsIssueItemIndex { get; set; }
    }
}
