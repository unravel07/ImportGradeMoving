using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImGoodsReceive
    {
        public ImGoodsReceive()
        {
            ImGoodsReceiveItem = new HashSet<ImGoodsReceiveItem>();
        }

        public Guid GoodsReceiveIndex { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string GoodsReceiveNo { get; set; }
        public DateTime GoodsReceiveDate { get; set; }
        public string DocumentRefNo1 { get; set; }
        public string DocumentRefNo2 { get; set; }
        public string DocumentRefNo3 { get; set; }
        public string DocumentRefNo4 { get; set; }
        public string DocumentRefNo5 { get; set; }
        public int? DocumentStatus { get; set; }
        public string DocumentRemark { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public int? DocumentPriorityStatus { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public int? PutawayStatus { get; set; }
        public Guid? WarehouseIndex { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public Guid? WarehouseIndexTo { get; set; }
        public string WarehouseIdTo { get; set; }
        public string WarehouseNameTo { get; set; }
        public Guid? DockDoorIndex { get; set; }
        public string DockDoorId { get; set; }
        public string DockDoorName { get; set; }
        public Guid? VehicleTypeIndex { get; set; }
        public string VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }
        public Guid? ContainerTypeIndex { get; set; }
        public string ContainerTypeId { get; set; }
        public string ContainerTypeName { get; set; }
        public string UserAssign { get; set; }
        public Guid? ReasonCodeIndex { get; set; }
        public string ReasonCodeId { get; set; }
        public string ReasonCodeName { get; set; }
        public string ReasonCodeBy { get; set; }
        public DateTime? ReasonCodeDate { get; set; }
        public string CustomInterfaceFlag1 { get; set; }
        public string CustomInterfaceFlag2 { get; set; }

        public virtual MsDocumentType DocumentTypeIndexNavigation { get; set; }
        public virtual MsOwner OwnerIndexNavigation { get; set; }
        public virtual MsWarehouse WarehouseIndexNavigation { get; set; }
        public virtual ICollection<ImGoodsReceiveItem> ImGoodsReceiveItem { get; set; }
    }
}
