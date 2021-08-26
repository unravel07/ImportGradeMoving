using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPickingRoute
    {
        public long? RowIndex { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteName { get; set; }
        public DateTime? DocDate { get; set; }
        public string RoundName { get; set; }
        public Guid? RoundIndex { get; set; }
        public int? QtyOrder { get; set; }
    }
}
