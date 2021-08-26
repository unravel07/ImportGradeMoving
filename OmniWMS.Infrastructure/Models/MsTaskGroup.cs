using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsTaskGroup
    {
        public MsTaskGroup()
        {
            MsTaskGroupEquipment = new HashSet<MsTaskGroupEquipment>();
            MsTaskGroupUser = new HashSet<MsTaskGroupUser>();
            MsTaskGroupWorkArea = new HashSet<MsTaskGroupWorkArea>();
        }

        public Guid TaskGroupIndex { get; set; }
        public string TaskGroupId { get; set; }
        public string TaskGroupName { get; set; }
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

        public virtual ICollection<MsTaskGroupEquipment> MsTaskGroupEquipment { get; set; }
        public virtual ICollection<MsTaskGroupUser> MsTaskGroupUser { get; set; }
        public virtual ICollection<MsTaskGroupWorkArea> MsTaskGroupWorkArea { get; set; }
    }
}
