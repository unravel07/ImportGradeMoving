using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewGoodsReceivePending
    {
        public Guid? PlanGoodsReceiveIndex { get; set; }
        public Guid PlanGoodsReceiveItemIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Ratio { get; set; }
        public decimal? TotalQty { get; set; }
        public decimal? GrtotalQty { get; set; }
        public decimal? Total { get; set; }
        public int? DocumentStatus { get; set; }
        public string ProductSecondName { get; set; }
    }
}
