using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPickShort
    {
        public Guid MarshallIndex { get; set; }
        public string MarshallNo { get; set; }
        public int? DocumentStatus { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundId { get; set; }
        public string RoundName { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public decimal Count { get; set; }
        public decimal? QtyBackOrder { get; set; }
        public string ProcessStatusName { get; set; }
    }
}
