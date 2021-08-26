using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OverallRoute
    {
        public int RowIndex { get; set; }
        public string RouteName { get; set; }
        public DateTime? DocDate { get; set; }
        public string OrderQty { get; set; }
    }
}
