using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPickingRouteOrderSnap
    {
        public long? RowIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public int ItemDocumentStatus { get; set; }
        public int? DocumentStatus { get; set; }
        public string OverallStatus { get; set; }
        public string OverallStatusCode { get; set; }
    }
}
