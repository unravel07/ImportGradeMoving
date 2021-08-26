using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewShippmentDispatchDetail
    {
        public long? RowIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Qty { get; set; }
        public decimal? PickingQty { get; set; }
        public decimal QtyBackOrder { get; set; }
        public string TruckLoadNo { get; set; }
        public Guid TruckLoadIndex { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
    }
}
