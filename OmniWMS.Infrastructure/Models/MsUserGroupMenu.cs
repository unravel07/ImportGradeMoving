using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsUserGroupMenu
    {
        public Guid UserGroupMenuIndex { get; set; }
        public string UserGroupMenuId { get; set; }
        public Guid? UserGroupIndex { get; set; }
        public Guid? MenuIndex { get; set; }
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

        public virtual SyMenu MenuIndexNavigation { get; set; }
        public virtual MsUserGroup UserGroupIndexNavigation { get; set; }
    }
}
