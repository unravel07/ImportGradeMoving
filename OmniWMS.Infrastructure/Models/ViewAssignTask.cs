using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewAssignTask
    {
        public Guid? PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid TaskIndex { get; set; }
        public string TaskNo { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundId { get; set; }
        public string RoundName { get; set; }
        public Guid? TaskGroupIndex { get; set; }
        public string TaskGroupId { get; set; }
        public string TaskGroupName { get; set; }
        public string UserAssign { get; set; }
        public int? DocumentPriorityStatus { get; set; }
    }
}
