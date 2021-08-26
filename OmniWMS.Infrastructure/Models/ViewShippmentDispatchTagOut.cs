using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewShippmentDispatchTagOut
    {
        public long? RowIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public Guid TruckLoadIndex { get; set; }
        public string TruckLoadNo { get; set; }
        public string TagOutNo { get; set; }
    }
}
