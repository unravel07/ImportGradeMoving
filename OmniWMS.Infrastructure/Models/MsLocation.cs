using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsLocation
    {
        public MsLocation()
        {
            ImGoodsTransferItem = new HashSet<ImGoodsTransferItem>();
            ImTransferStockAdjustmentItem = new HashSet<ImTransferStockAdjustmentItem>();
            MsLocationEquipment = new HashSet<MsLocationEquipment>();
            MsLocationWorkArea = new HashSet<MsLocationWorkArea>();
            MsZoneLocation = new HashSet<MsZoneLocation>();
        }

        public Guid LocationIndex { get; set; }
        public Guid WarehouseIndex { get; set; }
        public Guid RoomIndex { get; set; }
        public Guid LocationTypeIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public Guid LocationAisleIndex { get; set; }
        public int? LocationBay { get; set; }
        public int? LocationDepth { get; set; }
        public int? LocationLevel { get; set; }
        public decimal? MaxQty { get; set; }
        public decimal? MaxWeight { get; set; }
        public decimal? MaxVolume { get; set; }
        public decimal? MaxPallet { get; set; }
        public int? PutAwaySeq { get; set; }
        public int? PickingSeq { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }
        public int? IsSystem { get; set; }
        public int? StatusId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public decimal? LocationVolHeight { get; set; }
        public decimal? LocationVolWidth { get; set; }
        public decimal? LocationVolDepth { get; set; }
        public string LocationAspect { get; set; }
        public string LocationChekDigit { get; set; }

        public virtual MsLocationAisle LocationAisleIndexNavigation { get; set; }
        public virtual MsLocationType LocationTypeIndexNavigation { get; set; }
        public virtual MsRoom RoomIndexNavigation { get; set; }
        public virtual MsWarehouse WarehouseIndexNavigation { get; set; }
        public virtual ICollection<ImGoodsTransferItem> ImGoodsTransferItem { get; set; }
        public virtual ICollection<ImTransferStockAdjustmentItem> ImTransferStockAdjustmentItem { get; set; }
        public virtual ICollection<MsLocationEquipment> MsLocationEquipment { get; set; }
        public virtual ICollection<MsLocationWorkArea> MsLocationWorkArea { get; set; }
        public virtual ICollection<MsZoneLocation> MsZoneLocation { get; set; }
    }
}
