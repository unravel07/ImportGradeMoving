using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class GoodsReceiveItemTemp
    {
        public Guid GoodsReceiveItemIndex { get; set; }
        public Guid GoodsReceiveIndex { get; set; }
        public string LineNum { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public string QtyPlan { get; set; }
        public string Qty { get; set; }
        public string Ratio { get; set; }
        public string TotalQty { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public Guid? PalletIndex { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public string UnitWeight { get; set; }
        public string Weight { get; set; }
        public string UnitWidth { get; set; }
        public string UnitLength { get; set; }
        public string UnitHeight { get; set; }
        public string UnitVolume { get; set; }
        public string Volume { get; set; }
        public string UnitPrice { get; set; }
        public string Price { get; set; }
        public string DocumentRefNo1 { get; set; }
        public string DocumentRefNo2 { get; set; }
        public string DocumentRefNo3 { get; set; }
        public string DocumentRefNo4 { get; set; }
        public string DocumentRefNo5 { get; set; }
        public string DocumentStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public Guid? RefProcessIndex { get; set; }
        public string RefDocumentNo { get; set; }
        public string RefDocumentLineNum { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
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
