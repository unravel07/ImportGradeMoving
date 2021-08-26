using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewGoodsIssueGenTaskNoLock
    {
        public Guid GoodsIssueItemLocationIndex { get; set; }
        public Guid GoodsIssueItemIndex { get; set; }
        public Guid GoodsIssueIndex { get; set; }
        public Guid? TagItemIndex { get; set; }
        public Guid? TagIndex { get; set; }
        public string TagNo { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public decimal? Qty { get; set; }
        public decimal Ratio { get; set; }
        public decimal? TotalQty { get; set; }
        public Guid ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public int? DocumentStatus { get; set; }
        public string RefDocumentNo { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public Guid GoodsReceiveItemIndex { get; set; }
        public decimal? PickingQty { get; set; }
        public decimal? PickingRatio { get; set; }
        public decimal? PickingTotalQty { get; set; }
        public decimal Giqty { get; set; }
        public decimal GitotalQty { get; set; }
        public decimal TaskQty { get; set; }
        public decimal TaskTotalQty { get; set; }
    }
}
