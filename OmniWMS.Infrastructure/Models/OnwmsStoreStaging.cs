using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsStoreStaging
    {
        public OnwmsStoreStaging()
        {
            ExwmsMonitorMaster = new HashSet<ExwmsMonitorMaster>();
        }

        public string StoreNo { get; set; }
        public string LocationId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string PutawayType { get; set; }

        public virtual ICollection<ExwmsMonitorMaster> ExwmsMonitorMaster { get; set; }
    }
}
