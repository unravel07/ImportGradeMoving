using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCartAssign
    {
        public long? RowIndex { get; set; }
        public Guid GoodsIssueIndex { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string GoodsIssueNo { get; set; }
        public DateTime GoodsIssueDate { get; set; }
        public string DocumentRemark { get; set; }
        public int? DocumentStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public int? DocumentPriorityStatus { get; set; }
        public int? PickingStatus { get; set; }
        public Guid? WarehouseIndex { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public Guid TagOutPickIndex { get; set; }
        public string TagOutPickNo { get; set; }
        public string TagOutPickRefNo1 { get; set; }
        public string TagOutPickRefNo2 { get; set; }
        public string TagOutPickRefNo3 { get; set; }
        public string TagOutPickRefNo4 { get; set; }
        public string TagOutPickRefNo5 { get; set; }
        public int? TagOutPickStatus { get; set; }
        public Guid? ZoneIndex { get; set; }
        public Guid? RefProcessIndex { get; set; }
        public string RefDocumentNo { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public Guid TagOutIndex { get; set; }
        public string TagOutNo { get; set; }
        public string TagOutRefNo1 { get; set; }
        public int? TagOutStatus { get; set; }
        public string TagOutRefNo2 { get; set; }
        public Guid? EquipmentIndex { get; set; }
        public string EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
