using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewShippmentDispatchProduct
    {
        public long? RowIndex { get; set; }
        public string TruckLoadNo { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string SubOrderId { get; set; }
        public string DocumentRefNo1 { get; set; }
        public string DocumentRefNo2 { get; set; }
        public string DocumentRefNo3 { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Ratio { get; set; }
        public decimal? TotalQty { get; set; }
        public decimal QtyBackOrder { get; set; }
        public int ReplaceStatus { get; set; }
        public decimal? PickingQty { get; set; }
        public decimal? MarshallTaskPick { get; set; }
        public Guid? TruckLoadIndex { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public Guid PlanGoodsIssueItemIndex { get; set; }
        public string SourceStore { get; set; }
        public decimal? WeightTotal { get; set; }
        public decimal? ShipQty { get; set; }
        public int? SerialFlag { get; set; }
        public string BaseProductId { get; set; }
        public string DocumenttypeId { get; set; }
        public string SoldToId { get; set; }
    }
}
