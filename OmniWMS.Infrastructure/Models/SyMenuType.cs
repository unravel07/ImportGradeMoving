using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class SyMenuType
    {
        public SyMenuType()
        {
            SyMenu = new HashSet<SyMenu>();
        }

        public Guid MenuTypeIndex { get; set; }
        public string MenuTypeId { get; set; }
        public string MenuTypeName { get; set; }
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

        public virtual ICollection<SyMenu> SyMenu { get; set; }
    }
}
