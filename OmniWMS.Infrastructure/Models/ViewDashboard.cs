using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewDashboard
    {
        public int ObjectId { get; set; }
        public DateTime Date { get; set; }
        public Guid RoundIndex { get; set; }
        public Guid RouteIndex { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string F { get; set; }
        public string ACode { get; set; }
        public string BCode { get; set; }
        public string CCode { get; set; }
        public string FCode { get; set; }
        public string Status { get; set; }
        public bool? IsActive { get; set; }
        public string RoundName { get; set; }
        public string Seq { get; set; }
        public string RouteName { get; set; }
        public string PlanGoodsIssueNo { get; set; }
    }
}
