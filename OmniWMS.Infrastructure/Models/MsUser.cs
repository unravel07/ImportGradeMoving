using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsUser
    {
        public MsUser()
        {
            MsTaskGroupUser = new HashSet<MsTaskGroupUser>();
            MsUserEquipment = new HashSet<MsUserEquipment>();
        }

        public Guid UserIndex { get; set; }
        public Guid UserGroupIndex { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
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

        public virtual MsUserGroup UserGroupIndexNavigation { get; set; }
        public virtual ICollection<MsTaskGroupUser> MsTaskGroupUser { get; set; }
        public virtual ICollection<MsUserEquipment> MsUserEquipment { get; set; }
    }
}
