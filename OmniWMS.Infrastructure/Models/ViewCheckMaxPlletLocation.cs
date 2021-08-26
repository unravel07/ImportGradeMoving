using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCheckMaxPlletLocation
    {
        public string LocationName { get; set; }
        public string LocationId { get; set; }
        public Guid LocationIndex { get; set; }
        public int? PutAwaySeq { get; set; }
        public decimal? MaxPallet { get; set; }
        public int CountLpn { get; set; }
        public decimal? Lpn { get; set; }
    }
}
