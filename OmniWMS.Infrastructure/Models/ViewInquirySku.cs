using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewInquirySku
    {
        public long? RowIndex { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string LocationName { get; set; }
        public string GoodsReceiveNo { get; set; }
        public string ReceivingRef { get; set; }
        public DateTime? GoodsReceiveDate { get; set; }
        public string TagNo { get; set; }
        public string ItemStatusName { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public decimal? StockOnhand { get; set; }
        public decimal? StockAllocated { get; set; }
        public decimal? StockAvailable { get; set; }
        public string ProductConversionName { get; set; }
    }
}
