using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsStorePacking
    {
        public string StoreNo { get; set; }
        public Guid LocationIndex { get; set; }
        public string PackStationNo { get; set; }
        public string PackStationName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual OnwmsStoreMaster StoreNoNavigation { get; set; }
    }
}
