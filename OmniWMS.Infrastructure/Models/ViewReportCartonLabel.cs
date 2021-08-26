using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewReportCartonLabel
    {
        public Guid GoodsIssueIndex { get; set; }
        public DateTime GoodsIssueDate { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string TagOutPickNo { get; set; }
        public Guid TagOutIndex { get; set; }
        public string TagOutNo { get; set; }
        public string PlanGoodsIssueSize { get; set; }
        public string PlanGoodsIssueDueDate { get; set; }
        public string ShipToName { get; set; }
        public string ShipToAddress { get; set; }
        public string RoundName { get; set; }
        public string RouteName { get; set; }
        public string ZoneName { get; set; }
        public int? IsPrint { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Udf5 { get; set; }
        public int? MstotalQty { get; set; }
        public int? ItemTotalQty { get; set; }
        public string PickManual { get; set; }
    }
}
