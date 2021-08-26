using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewGiprocessStatus
    {
        public Guid GoodsIssueIndex { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string GoodsIssueNo { get; set; }
        public DateTime GoodsIssueDate { get; set; }
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
        public int? DocumentPriorityStatus { get; set; }
        public int? PickingStatus { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public Guid? WarehouseIndex { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public string ProcessStatusName { get; set; }
    }
}
