using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsTaskGroupEquipment
    {
        public Guid TaskGroupEquipmentIndex { get; set; }
        public string TaskGroupEquipmentId { get; set; }
        public Guid TaskGroupIndex { get; set; }
        public Guid EquipmentIndex { get; set; }
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

        public virtual MsEquipment EquipmentIndexNavigation { get; set; }
        public virtual MsTaskGroup TaskGroupIndexNavigation { get; set; }
    }
}
