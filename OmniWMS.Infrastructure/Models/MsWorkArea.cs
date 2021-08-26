using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsWorkArea
    {
        public MsWorkArea()
        {
            MsLocationWorkArea = new HashSet<MsLocationWorkArea>();
            MsTaskGroupWorkArea = new HashSet<MsTaskGroupWorkArea>();
        }

        public Guid WorkAreaIndex { get; set; }
        public string WorkAreaId { get; set; }
        public string WorkAreaName { get; set; }
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

        public virtual ICollection<MsLocationWorkArea> MsLocationWorkArea { get; set; }
        public virtual ICollection<MsTaskGroupWorkArea> MsTaskGroupWorkArea { get; set; }
    }
}
