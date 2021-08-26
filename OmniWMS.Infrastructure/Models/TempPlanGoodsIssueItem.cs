using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class TempPlanGoodsIssueItem
    {
        public string PlanGoodsIssueItemIndex { get; set; }
        public string PlanGoodsIssueIndex { get; set; }
        public double? LineNum { get; set; }
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
        public double? ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public string MfgDate { get; set; }
        public string ExpDate { get; set; }
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
        public string DocumentRemark { get; set; }
        public double? DocumentStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public string UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public string CancelDate { get; set; }
        public double? QtyBackOrder { get; set; }
        public double? BackOrderStatus { get; set; }
        public string PlanGoodsIssueSize { get; set; }
        public string QtyQa { get; set; }
        public string IsQa { get; set; }
        public string QtyInnerPack { get; set; }
        public string QtySupPack { get; set; }
        public string ImageUri { get; set; }
        public string ZoneCode { get; set; }
        public string BatchId { get; set; }
        public string QaBy { get; set; }
        public string QaDate { get; set; }
    }
}
