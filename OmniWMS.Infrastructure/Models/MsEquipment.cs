using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsEquipment
    {
        public MsEquipment()
        {
            MsLocationEquipment = new HashSet<MsLocationEquipment>();
            MsTaskGroupEquipment = new HashSet<MsTaskGroupEquipment>();
            MsUserEquipment = new HashSet<MsUserEquipment>();
        }

        public Guid EquipmentIndex { get; set; }
        public string EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public Guid EquipmentTypeIndex { get; set; }
        public Guid EquipmentSubTypeIndex { get; set; }
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

        public virtual MsEquipmentSubType EquipmentSubTypeIndexNavigation { get; set; }
        public virtual MsEquipmentType EquipmentTypeIndexNavigation { get; set; }
        public virtual ICollection<MsLocationEquipment> MsLocationEquipment { get; set; }
        public virtual ICollection<MsTaskGroupEquipment> MsTaskGroupEquipment { get; set; }
        public virtual ICollection<MsUserEquipment> MsUserEquipment { get; set; }
    }
}
