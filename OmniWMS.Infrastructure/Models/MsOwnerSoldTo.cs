using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsOwnerSoldTo
    {
        public Guid OwnerSoldToIndex { get; set; }
        public string OwnerSoldToId { get; set; }
        public Guid? OwnerIndex { get; set; }
        public Guid? SoldToIndex { get; set; }
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

        public virtual MsOwner OwnerIndexNavigation { get; set; }
        public virtual MsSoldTo SoldToIndexNavigation { get; set; }
    }
}
