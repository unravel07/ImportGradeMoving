using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsWarehouse
    {
        public MsWarehouse()
        {
            ImGoodsReceive = new HashSet<ImGoodsReceive>();
            ImPlanGoodsReceive = new HashSet<ImPlanGoodsReceive>();
            MsLocation = new HashSet<MsLocation>();
            MsRoom = new HashSet<MsRoom>();
        }

        public Guid WarehouseIndex { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
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

        public virtual ICollection<ImGoodsReceive> ImGoodsReceive { get; set; }
        public virtual ICollection<ImPlanGoodsReceive> ImPlanGoodsReceive { get; set; }
        public virtual ICollection<MsLocation> MsLocation { get; set; }
        public virtual ICollection<MsRoom> MsRoom { get; set; }
    }
}
