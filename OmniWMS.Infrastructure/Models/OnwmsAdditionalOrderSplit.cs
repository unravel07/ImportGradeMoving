using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsAdditionalOrderSplit
    {
        public string OwnerId { get; set; }
        public string DocumentTypeId { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string PlanGoodsIssueNoRef { get; set; }
        public string ProductId { get; set; }
        public decimal? Qty { get; set; }
        public string UoM { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
