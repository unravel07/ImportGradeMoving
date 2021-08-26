using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewTaskPickListDropAutoTask
    {
        public long? RowIndex { get; set; }
        public Guid GoodsIssueIndex { get; set; }
        public string GoodsIssueNo { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public Guid? EquipmentIndex { get; set; }
        public string EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentItemId { get; set; }
        public Guid? EquipmentItemIndex { get; set; }
        public string EquipmentItemName { get; set; }
        public string EquipmentItemDesc { get; set; }
        public Guid TagOutPickIndex { get; set; }
        public string TagOutPickNo { get; set; }
        public string SuggestLocationName { get; set; }
        public int? TagOutPickStatus { get; set; }
        public string TagOutNo { get; set; }
        public int? TagOutStatus { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid SoldToIndex { get; set; }
        public string SoldToId { get; set; }
        public string SoldToName { get; set; }
        public Guid ShipToIndex { get; set; }
        public string ShipToId { get; set; }
        public string ShipToName { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public DateTime PlanGoodsIssueDate { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundId { get; set; }
        public string RoundName { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public Guid? TaskItemIndex { get; set; }
        public Guid? TaskIndex { get; set; }
        public string TaskNo { get; set; }
        public Guid? TagItemIndex { get; set; }
        public Guid? TagIndex { get; set; }
        public string TagNo { get; set; }
        public int? DocumentStatus { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public Guid? LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
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
        public Guid GoodsIssueItemLocationIndex { get; set; }
        public Guid? PlanGoodsIssueItemIndex { get; set; }
        public decimal? PickingQty { get; set; }
        public int? GoodsIssueItemLocationStatus { get; set; }
        public int? PickingSeq { get; set; }
    }
}
