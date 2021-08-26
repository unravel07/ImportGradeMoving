using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewOrderPerformanceByRoute
    {
        public long? RowIndex { get; set; }
        public string RouteName { get; set; }
        public DateTime? DocDate { get; set; }
        public int? OrderQty { get; set; }
    }
}
