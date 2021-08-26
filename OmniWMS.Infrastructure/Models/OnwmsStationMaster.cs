using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsStationMaster
    {
        public OnwmsStationMaster()
        {
            ExwmsMonitorMaster = new HashSet<ExwmsMonitorMaster>();
        }

        public string StationId { get; set; }
        public string StationName { get; set; }
        public string StatusId { get; set; }
        public string UserAssign { get; set; }
        public string PutawayTypeAlias { get; set; }
        public string PutawayType { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }

        public virtual ICollection<ExwmsMonitorMaster> ExwmsMonitorMaster { get; set; }
    }
}
