using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPickingRouteOrderDetailStatusSnap
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
        public int? Seq { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public string PickStatus { get; set; }
        public string PickStatusCode { get; set; }
        public string OverallStatus { get; set; }
        public string OverallStatusCode { get; set; }
    }
}
