using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class TempLocationChill
    {
        public string LocationId { get; set; }
        public string PutAwaySeq { get; set; }
        public string PickingSeq { get; set; }
        public string IsNew { get; set; }
    }
}
