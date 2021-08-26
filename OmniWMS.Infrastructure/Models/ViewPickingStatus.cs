using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPickingStatus
    {
        public long? RowIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public string PickStatus { get; set; }
        public string PickStatusCode { get; set; }
        public Guid? ZoneIndex { get; set; }
        public int Seq { get; set; }
    }
}
