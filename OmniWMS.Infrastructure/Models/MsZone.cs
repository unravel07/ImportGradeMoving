using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsZone
    {
        public MsZone()
        {
            MsRuleZone = new HashSet<MsRuleZone>();
            MsUserGroupZone = new HashSet<MsUserGroupZone>();
            MsZoneLocation = new HashSet<MsZoneLocation>();
        }

        public Guid ZoneIndex { get; set; }
        public string ZoneId { get; set; }
        public string ZoneName { get; set; }
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

        public virtual ICollection<MsRuleZone> MsRuleZone { get; set; }
        public virtual ICollection<MsUserGroupZone> MsUserGroupZone { get; set; }
        public virtual ICollection<MsZoneLocation> MsZoneLocation { get; set; }
    }
}
