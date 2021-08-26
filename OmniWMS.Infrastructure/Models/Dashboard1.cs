using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class Dashboard1
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
        public string Status { get; set; }
        public bool? IsActive { get; set; }

        public virtual ImPlanGoodsIssue PlanGoodsIssueIndexNavigation { get; set; }
        public virtual MsRound RoundIndexNavigation { get; set; }
        public virtual MsRoute RouteIndexNavigation { get; set; }
    }
}
