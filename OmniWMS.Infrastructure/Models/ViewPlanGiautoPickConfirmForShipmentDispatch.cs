using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPlanGiautoPickConfirmForShipmentDispatch
    {
        public Guid PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public int? CountPlanOk { get; set; }
        public int? CountPlanNotOk { get; set; }
    }
}
