using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsRouteSequence
    {
        public long RouteseqNo { get; set; }
        public string RouteId { get; set; }
        public int? SeqNo { get; set; }
        public string StoreNo { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
