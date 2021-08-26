using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsTaskGroupWorkArea
    {
        public Guid TaskGroupWorkAreaIndex { get; set; }
        public string TaskGroupWorkAreaId { get; set; }
        public Guid TaskGroupIndex { get; set; }
        public Guid WorkAreaIndex { get; set; }
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

        public virtual MsTaskGroup TaskGroupIndexNavigation { get; set; }
        public virtual MsWorkArea WorkAreaIndexNavigation { get; set; }
    }
}
