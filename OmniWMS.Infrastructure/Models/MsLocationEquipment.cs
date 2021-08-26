using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsLocationEquipment
    {
        public Guid LocationEquipmentIndex { get; set; }
        public string LocationEquipmentId { get; set; }
        public Guid? LocationIndex { get; set; }
        public Guid? EquipmentIndex { get; set; }
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

        public virtual MsEquipment EquipmentIndexNavigation { get; set; }
        public virtual MsLocation LocationIndexNavigation { get; set; }
    }
}
