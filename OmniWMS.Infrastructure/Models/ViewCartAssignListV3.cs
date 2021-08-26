using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCartAssignListV3
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
        public string TagOutPickNo { get; set; }
        public int? TagOutPickStatus { get; set; }
        public string TagOutNo { get; set; }
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
        public int? GoodsIssueItemLocationStatus { get; set; }
    }
}
