using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class TempImGoodReceiveItems
    {
        public double? IsUse { get; set; }
        public string GoodsReceiveItemIndex { get; set; }
        public string GoodsReceiveIndex { get; set; }
        public string LineNum { get; set; }
        public string ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public string ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public double? QtyPlan { get; set; }
        public double? Qty { get; set; }
        public double? Ratio { get; set; }
        public double? TotalQty { get; set; }
        public string ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public string PalletIndex { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public double? UnitWeight { get; set; }
        public double? Weight { get; set; }
        public double? UnitWidth { get; set; }
        public double? UnitLength { get; set; }
        public double? UnitHeight { get; set; }
        public double? UnitVolume { get; set; }
        public double? Volume { get; set; }
        public double? UnitPrice { get; set; }
        public double? Price { get; set; }
        public string DocumentRefNo1 { get; set; }
        public string DocumentRefNo2 { get; set; }
        public string DocumentRefNo3 { get; set; }
        public string DocumentRefNo4 { get; set; }
        public string DocumentRefNo5 { get; set; }
        public int? DocumentStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public string RefProcessIndex { get; set; }
        public string RefDocumentNo { get; set; }
        public string RefDocumentLineNum { get; set; }
        public string RefDocumentIndex { get; set; }
        public string RefDocumentItemIndex { get; set; }
        public string GoodsReceiveRemark { get; set; }
        public string GoodsReceiveDockDoor { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public string CancelDate { get; set; }
    }
}
