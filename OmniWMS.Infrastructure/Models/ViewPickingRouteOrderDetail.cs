using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPickingRouteOrderDetail
    {
        public long? RowIndex { get; set; }
        public Guid ZoneIndex { get; set; }
        public string ZoneName { get; set; }
        public string DocZone { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteName { get; set; }
        public DateTime? DocDate { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundName { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
    }
}
