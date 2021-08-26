using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPlanwavebyPlanginoLock
    {
        public Guid PlanGoodsIssueIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid OwnerIndex { get; set; }
        public Guid SoldToIndex { get; set; }
        public string SoldToId { get; set; }
        public string SoldToName { get; set; }
        public string SoldToAddress { get; set; }
        public Guid ShipToIndex { get; set; }
        public string ShipToId { get; set; }
        public string ShipToName { get; set; }
        public string ShipToAddress { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public DateTime PlanGoodsIssueDate { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public Guid PlanGoodsIssueItemIndex { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public decimal? Qty { get; set; }
        public string ItemStatusName { get; set; }
        public decimal? Ratio { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public decimal? TotalQty { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public decimal? UnitWeight { get; set; }
        public decimal? Weight { get; set; }
        public decimal? UnitWidth { get; set; }
        public decimal? UnitLength { get; set; }
        public decimal? UnitHeight { get; set; }
        public decimal? Volume { get; set; }
        public decimal? UnitVolume { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Price { get; set; }
        public int DocumentPriorityStatus { get; set; }
        public int? DocumentStatus { get; set; }
        public int? ItemDocumentStatus { get; set; }
        public string DocumentRefNo1 { get; set; }
        public string DocumentRefNo2 { get; set; }
        public string DocumentRefNo3 { get; set; }
        public string DocumentRefNo4 { get; set; }
        public string DocumentRefNo5 { get; set; }
        public string DocumentRemark { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public decimal GitotalQty { get; set; }
        public string PlanGoodsIssueUdf1 { get; set; }
        public string PlanGoodsIssueUdf2 { get; set; }
        public string PlanGoodsIssueUdf3 { get; set; }
        public string PlanGoodsIssueUdf4 { get; set; }
        public string PlanGoodsIssueUdf5 { get; set; }
    }
}
