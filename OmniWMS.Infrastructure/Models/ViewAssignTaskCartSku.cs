using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewAssignTaskCartSku
    {
        public long? RowNumber { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid TaskIndex { get; set; }
        public string TaskNo { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundId { get; set; }
        public string RoundName { get; set; }
        public Guid? TaskGroupIndex { get; set; }
        public string TaskGroupId { get; set; }
        public string TaskGroupName { get; set; }
        public string UserAssign { get; set; }
        public int? DocumentPriorityStatus { get; set; }
        public Guid? EquipmentIndex { get; set; }
        public string EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public Guid? EquipmentItemIndex { get; set; }
        public string EquipmentItemId { get; set; }
        public string EquipmentItemName { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public decimal? TotalQty { get; set; }
    }
}
