using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewShipmentDispatchCancel
    {
        public Guid PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string RoundId { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public bool? IsPostShippmentDispatch { get; set; }
    }
}
