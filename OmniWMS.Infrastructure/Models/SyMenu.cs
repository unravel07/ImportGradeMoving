using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class SyMenu
    {
        public SyMenu()
        {
            MsUserGroupMenu = new HashSet<MsUserGroupMenu>();
        }

        public Guid MenuIndex { get; set; }
        public Guid? MenuTypeIndex { get; set; }
        public string MenuId { get; set; }
        public string MenuControlName { get; set; }
        public string MenuName { get; set; }
        public string MenuSecondName { get; set; }
        public string MenuThirdName { get; set; }
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

        public virtual SyMenuType MenuTypeIndexNavigation { get; set; }
        public virtual ICollection<MsUserGroupMenu> MsUserGroupMenu { get; set; }
    }
}
