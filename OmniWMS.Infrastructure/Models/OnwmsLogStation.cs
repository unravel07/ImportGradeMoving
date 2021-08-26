using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsLogStation
    {
        public int LogId { get; set; }
        public int? StationId { get; set; }
        public string StationEvent { get; set; }
        public string TagNo { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
