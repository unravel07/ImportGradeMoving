using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewReturnReceive
    {
        public Guid PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public DateTime PlanGoodsIssueDate { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public string DocumentRefNo1 { get; set; }
        public string DocumentRemark { get; set; }
        public Guid? WarehouseIndex { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseId { get; set; }
        public Guid? WarehouseIndexTo { get; set; }
        public string WarehouseIdTo { get; set; }
        public string WarehouseNameTo { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public string CancelBy { get; set; }
        public int? BackOrderStatus { get; set; }
        public Guid? CountryIndex { get; set; }
        public Guid? DistrictIndex { get; set; }
        public int? DocumentPriorityStatus { get; set; }
        public int? DocumentStatus { get; set; }
        public string RefPlanGoodsIssueNo { get; set; }
    }
}
