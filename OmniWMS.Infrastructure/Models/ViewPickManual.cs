using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPickManual
    {
        public long? RowId { get; set; }
        public Guid GoodsIssueItemLocationIndex { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid GoodsIssueIndex { get; set; }
        public string GoodsIssueNo { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal TotalQty { get; set; }
        public string ProductConversionName { get; set; }
        public decimal? BinBalanceQtyBal { get; set; }
        public string ProductConversionBarcode { get; set; }
        public Guid? BinBalanceIndex { get; set; }
    }
}
