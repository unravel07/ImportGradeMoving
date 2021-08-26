using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsTempImportSalesorder
    {
        public string OwnerId { get; set; }
        public string WarehouseId { get; set; }
        public string StoreId { get; set; }
        public string OrderNo { get; set; }
        public DateTime DueDate { get; set; }
        public int LineNo { get; set; }
        public string DocumentstatusId { get; set; }
        public string StatusValidate { get; set; }
        public string StatusRemark { get; set; }
        public string ProductConversionBarcode { get; set; }
        public decimal Qty { get; set; }
        public decimal? Weight { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public string ReferenceNo1 { get; set; }
        public string ReferenceNo2 { get; set; }
        public string ReferenceNo3 { get; set; }
        public string ReferenceNo4 { get; set; }
        public string ReferenceNo5 { get; set; }
        public string Remark { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string PathFile { get; set; }
        public Guid TaskNo { get; set; }
        public string Uom { get; set; }
    }
}
