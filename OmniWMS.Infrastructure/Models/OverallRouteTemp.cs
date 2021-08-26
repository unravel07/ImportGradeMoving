using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OverallRouteTemp
    {
        public int? RowIndex { get; set; }
        public string RouteName { get; set; }
        public string DocDate { get; set; }
        public string OrderQty { get; set; }
    }
}
