using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPlanCarton
    {
        public string TagOutNo { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string RefPlanGoodsIssueNo { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
    }
}
