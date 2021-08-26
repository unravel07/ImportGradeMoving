using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewReportGoodsReceiveNote
    {
        public string OwnerName { get; set; }
        public string GoodsReceiveNo { get; set; }
        public string WarehouseName { get; set; }
        public string Supplier { get; set; }
        public string DocumentTypeName { get; set; }
        public string GoodsReceiveDate { get; set; }
        public string GoodsReceiveTime { get; set; }
        public string ProductName { get; set; }
        public decimal? Qty { get; set; }
        public string ProductConversionName { get; set; }
        public string GoodsReceiveRemark { get; set; }
        public string RefDocumentNo { get; set; }
        public string RefDocumentLineNum { get; set; }
    }
}
