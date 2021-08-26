using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsOwnerVendor
    {
        public Guid OwnerVendorIndex { get; set; }
        public string OwnerVendorId { get; set; }
        public Guid? OwnerIndex { get; set; }
        public Guid? VendorIndex { get; set; }
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
        public virtual MsVendor VendorIndexNavigation { get; set; }
    }
}
