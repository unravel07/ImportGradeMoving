using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class SnapImPlanGoodsIssueItem
    {
        public Guid PlanGoodsIssueItemIndex { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
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
        public decimal? Qty { get; set; }
        public decimal? Ratio { get; set; }
        public decimal? TotalQty { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public decimal? UnitWeight { get; set; }
        public decimal? Weight { get; set; }
        public decimal? UnitWidth { get; set; }
        public decimal? UnitLength { get; set; }
        public decimal? UnitHeight { get; set; }
        public decimal? UnitVolume { get; set; }
        public decimal? Volume { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Price { get; set; }
        public string DocumentRefNo1 { get; set; }
        public string DocumentRefNo2 { get; set; }
        public string DocumentRefNo3 { get; set; }
        public string DocumentRefNo4 { get; set; }
        public string DocumentRefNo5 { get; set; }
        public string DocumentRemark { get; set; }
        public int? DocumentStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public decimal? QtyBackOrder { get; set; }
        public int? BackOrderStatus { get; set; }
        public string PlanGoodsIssueSize { get; set; }
        public decimal? QtyQa { get; set; }
        public int? IsQa { get; set; }
        public decimal? QtyInnerPack { get; set; }
        public decimal? QtySupPack { get; set; }
        public string ImageUri { get; set; }
        public string ZoneCode { get; set; }
        public string BatchId { get; set; }
        public string QaBy { get; set; }
        public DateTime? QaDate { get; set; }
        public int? RunWaveStatus { get; set; }
        public string IsWeightItem { get; set; }
        public decimal? QtyRemark { get; set; }
        public string IsWeightByPiece { get; set; }
    }
}
