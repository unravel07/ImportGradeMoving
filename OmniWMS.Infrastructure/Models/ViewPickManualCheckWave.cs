using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPickManualCheckWave
    {
        public long? RowIndex { get; set; }
        public int? GoodsIssueItemLocationIndex { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public int? GoodsIssueIndex { get; set; }
        public int? GoodsIssueNo { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal TotalQty { get; set; }
        public string ProductConversionName { get; set; }
        public decimal BinBalanceQtyBal { get; set; }
        public string ProductConversionBarcode { get; set; }
    }
}
