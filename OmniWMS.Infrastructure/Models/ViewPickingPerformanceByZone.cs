using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPickingPerformanceByZone
    {
        public long? RowIndex { get; set; }
        public string ZoneName { get; set; }
        public DateTime? DocDate { get; set; }
        public decimal? PickQty { get; set; }
        public decimal? Fulfilled { get; set; }
        public decimal? UnFulfilled { get; set; }
        public decimal? Remain { get; set; }
    }
}
