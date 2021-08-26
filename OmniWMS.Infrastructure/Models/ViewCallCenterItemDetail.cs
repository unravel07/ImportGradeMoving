using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCallCenterItemDetail
    {
        public Guid CallCenterIndex { get; set; }
        public string CallCenterNo { get; set; }
        public Guid OwnerIndex { get; set; }
        public Guid CallCenterItemIndex { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public Guid ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public decimal? QtyPlan { get; set; }
        public decimal Qty { get; set; }
        public decimal TotalQty { get; set; }
        public decimal Ratio { get; set; }
        public Guid ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public decimal Weight { get; set; }
        public decimal? UnitWeight { get; set; }
        public decimal UnitWidth { get; set; }
        public decimal UnitLength { get; set; }
        public decimal UnitHeight { get; set; }
        public decimal UnitVolume { get; set; }
        public decimal Volume { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }
        public string DocumentRefNo1 { get; set; }
        public string DocumentRefNo2 { get; set; }
        public string DocumentRefNo3 { get; set; }
        public string DocumentRefNo4 { get; set; }
        public string DocumentRefNo5 { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public int? DocumentStatus { get; set; }
        public string CallCenterRemark { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public string RefDocumentNo { get; set; }
        public Guid? RefProcessIndex { get; set; }
        public decimal MarshalQty { get; set; }
        public decimal? MarshalRatio { get; set; }
        public decimal MarshalTotalQty { get; set; }
        public decimal PickingQty { get; set; }
        public decimal? PickingRatio { get; set; }
        public decimal PickingTotalQty { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public Guid? PlanGoodsIssueItemIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string PlanProductId { get; set; }
        public string ProductConversionBarcode { get; set; }
        public Guid ReasonCodeIndex { get; set; }
        public string ReasonCodeId { get; set; }
        public string ReasonCodeName { get; set; }
        public int ReplaceStatus { get; set; }
    }
}
