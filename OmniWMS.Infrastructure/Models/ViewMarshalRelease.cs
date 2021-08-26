using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewMarshalRelease
    {
        public decimal? PlanGiBackOrder { get; set; }
        public decimal? PlanGiTotalQty { get; set; }
        public decimal? PlanGiQty { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundId { get; set; }
        public string RoundName { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerName { get; set; }
        public string OwnerId { get; set; }
        public Guid? WarehouseIndex { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public int? DocumentStatus { get; set; }
        public DateTime PlanGoodsIssueDate { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public int? BackOrderStatus { get; set; }
        public string ProcessStatusName { get; set; }
    }
}
