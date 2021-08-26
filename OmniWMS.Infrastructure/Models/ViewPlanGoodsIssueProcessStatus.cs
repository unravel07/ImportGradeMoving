using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPlanGoodsIssueProcessStatus
    {
        public string PlanGoodsIssueNo { get; set; }
        public string OverallStatus { get; set; }
        public int Seq { get; set; }
        public string TagOutPick { get; set; }
    }
}
