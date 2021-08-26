using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsRoundTimeTable
    {
        public int OrderRound { get; set; }
        public int? TruckRound { get; set; }
        public string OrderTime { get; set; }
        public string OrderType { get; set; }
        public int? Datestart { get; set; }
        public int? Dateend { get; set; }
        public string Timestart { get; set; }
        public string Timeend { get; set; }
        public int? DuedateAdd { get; set; }
        public int LineNo { get; set; }
    }
}
