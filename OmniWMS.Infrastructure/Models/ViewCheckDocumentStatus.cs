using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCheckDocumentStatus
    {
        public int? PlanGrdocumentStatus { get; set; }
        public int? GrdocumentStatus { get; set; }
        public string PlanGoodsReceiveNo { get; set; }
        public Guid GoodsReceiveIndex { get; set; }
    }
}
