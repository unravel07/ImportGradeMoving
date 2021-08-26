using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class SnapWmTagoutpick
    {
        public Guid TagOutPickIndex { get; set; }
        public string TagOutPickNo { get; set; }
        public string TagOutPickRefNo1 { get; set; }
        public string TagOutPickRefNo2 { get; set; }
        public string TagOutPickRefNo3 { get; set; }
        public string TagOutPickRefNo4 { get; set; }
        public string TagOutPickRefNo5 { get; set; }
        public int? TagOutPickStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public Guid? ZoneIndex { get; set; }
        public Guid? RefProcessIndex { get; set; }
        public string RefDocumentNo { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public Guid? EquipmentIndex { get; set; }
        public string EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public Guid? EquipmentItemIndex { get; set; }
        public string EquipmentItemId { get; set; }
        public string EquipmentItemName { get; set; }
        public decimal? ConfirmTagOutQty { get; set; }
        public string SuggestLocationName { get; set; }
        public string TagOutPickSize { get; set; }
        public string PickingBy { get; set; }
        public DateTime? PickingDate { get; set; }
        public int? PickingStatus { get; set; }
        public string UserAssign { get; set; }
        public string EquipmentItemDesc { get; set; }
    }
}
