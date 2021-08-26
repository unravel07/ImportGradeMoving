using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsUserGroupZone
    {
        public Guid UserGroupZoneIndex { get; set; }
        public string UserGroupZoneId { get; set; }
        public Guid? UserGroupIndex { get; set; }
        public Guid? ZoneIndex { get; set; }
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
        public virtual MsZone ZoneIndexNavigation { get; set; }
    }
}
