using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewScanQa
    {
        public long? RowIndex { get; set; }
        public Guid TagOutPickIndex { get; set; }
        public string TagOutPickNo { get; set; }
        public int? TagOutPickStatus { get; set; }
        public int? TagOutStatus { get; set; }
        public Guid GoodsIssueIndex { get; set; }
        public Guid GoodsIssueItemLocationIndex { get; set; }
        public string ZoneId { get; set; }
        public string ZoneName { get; set; }
        public Guid? RefProcessIndex { get; set; }
        public string GoodsIssueNo { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public int? DocumentStatus { get; set; }
        public Guid? ZoneIndex { get; set; }
        public string PickedBy { get; set; }
        public decimal? PickingQty { get; set; }
        public Guid PlanGoodsIssueItemIndex { get; set; }
        public decimal? QtyQa { get; set; }
        public int? IsQa { get; set; }
        public decimal? QtyBackOrder { get; set; }
        public decimal? Qty { get; set; }
        public string ProductName { get; set; }
    }
}
