using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewOverallPerformanceStatusExpress
    {
        public long? RowIndex { get; set; }
        public string StatusName { get; set; }
        public DateTime? DocDate { get; set; }
        public int? Qty { get; set; }
    }
}
