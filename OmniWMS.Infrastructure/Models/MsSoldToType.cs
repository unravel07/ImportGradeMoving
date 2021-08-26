using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsSoldToType
    {
        public MsSoldToType()
        {
            MsSoldTo = new HashSet<MsSoldTo>();
        }

        public Guid SoldToTypeIndex { get; set; }
        public string SoldToTypeId { get; set; }
        public string SoldToTypeName { get; set; }
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

        public virtual ICollection<MsSoldTo> MsSoldTo { get; set; }
    }
}
