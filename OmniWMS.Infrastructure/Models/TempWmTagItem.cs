using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class TempWmTagItem
    {
        public double? IsUse { get; set; }
        public string TagItemIndex { get; set; }
        public string TagIndex { get; set; }
        public string TagNo { get; set; }
        public string GoodsReceiveIndex { get; set; }
        public string GoodsReceiveItemIndex { get; set; }
        public string ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public string ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public double? Qty { get; set; }
        public double? Ratio { get; set; }
        public double? TotalQty { get; set; }
        public string ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public double? Weight { get; set; }
        public double? Volume { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public string TagRefNo1 { get; set; }
        public string TagRefNo2 { get; set; }
        public string TagRefNo3 { get; set; }
        public string TagRefNo4 { get; set; }
        public string TagRefNo5 { get; set; }
        public double? TagStatus { get; set; }
        public double? Udf1 { get; set; }
        public double? Udf2 { get; set; }
        public double? Udf3 { get; set; }
        public double? Udf4 { get; set; }
        public double? Udf5 { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
