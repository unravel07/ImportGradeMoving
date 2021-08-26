using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ZzLocationMaster
    {
        public string Zone { get; set; }
        public string Row { get; set; }
        public string Bay { get; set; }
        public double? Level { get; set; }
        public string Slot { get; set; }
        public string LocationName { get; set; }
    }
}
