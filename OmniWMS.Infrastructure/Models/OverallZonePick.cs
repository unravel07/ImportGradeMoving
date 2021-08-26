using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OverallZonePick
    {
        public int RowIndex { get; set; }
        public string ZoneName { get; set; }
        public DateTime? DocDate { get; set; }
        public string PickQty { get; set; }
        public string Fulfilled { get; set; }
        public string UnFulfilled { get; set; }
        public string Remain { get; set; }
    }
}
