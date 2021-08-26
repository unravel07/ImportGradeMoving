using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsLocationType
    {
        public MsLocationType()
        {
            MsLocation = new HashSet<MsLocation>();
        }

        public Guid LocationTypeIndex { get; set; }
        public string LocationTypeId { get; set; }
        public string LocationTypeName { get; set; }
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

        public virtual ICollection<MsLocation> MsLocation { get; set; }
    }
}
