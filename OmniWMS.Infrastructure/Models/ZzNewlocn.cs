using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ZzNewlocn
    {
        public string Location { get; set; }
        public double? PutAwaySeq { get; set; }
        public double? PickingSeq { get; set; }
        public string ZoneName { get; set; }
    }
}
