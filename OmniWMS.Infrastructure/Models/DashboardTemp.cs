using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class DashboardTemp
    {
        public int? RowIndex { get; set; }
        public string ZoneIndex { get; set; }
        public string ZoneName { get; set; }
        public string DocZone { get; set; }
        public string RouteIndex { get; set; }
        public string RouteName { get; set; }
        public string DocDate { get; set; }
        public string RoundIndex { get; set; }
        public string RoundName { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string PlanGoodsIssueIndex { get; set; }
        public string PickStatus { get; set; }
        public string PickStatusCode { get; set; }
        public string OverallStatus { get; set; }
        public string OverallStatusCode { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string DocumentTypeId { get; set; }
        public string Seq { get; set; }
        public string Udf2 { get; set; }
    }
}
