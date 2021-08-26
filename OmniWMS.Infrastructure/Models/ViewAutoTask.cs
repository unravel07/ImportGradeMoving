using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewAutoTask
    {
        public long? RowIndex { get; set; }
        public Guid? GoodsIssueIndex { get; set; }
        public string GoodsIssueNo { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public Guid TaskIndex { get; set; }
        public string TaskNo { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public Guid ZoneIndex { get; set; }
        public string ZoneId { get; set; }
        public string ZoneName { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundId { get; set; }
        public string RoundName { get; set; }
        public string User { get; set; }
        public int? DocumentPriorityStatus { get; set; }
    }
}
