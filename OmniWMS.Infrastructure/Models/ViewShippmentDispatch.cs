using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewShippmentDispatch
    {
        public long? RowIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string TagOutNo { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
    }
}
