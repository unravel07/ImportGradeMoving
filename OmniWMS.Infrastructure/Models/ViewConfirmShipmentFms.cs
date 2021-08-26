using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewConfirmShipmentFms
    {
        public Guid PosIndex { get; set; }
        public string PosNo { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string SubOrderId { get; set; }
        public bool IsPostShippmentDispatch { get; set; }
        public bool IsConfirmShipmentFms { get; set; }
        public string UpdateBy { get; set; }
        public string ConfirmBy { get; set; }
    }
}
