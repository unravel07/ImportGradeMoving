using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class SnapDashboard
    {
        public int RowIndex { get; set; }
        public Guid? ZoneIndex { get; set; }
        public string ZoneName { get; set; }
        public string DocZone { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteName { get; set; }
        public DateTime? DocDate { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundName { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public string PickStatus { get; set; }
        public string PickStatusCode { get; set; }
        public string OverallStatus { get; set; }
        public string OverallStatusCode { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string DocumentTypeId { get; set; }
        public int? Seq { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
