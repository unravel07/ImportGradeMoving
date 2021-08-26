using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewInquirySkuAllocatedBy
    {
        public long? RowIndex { get; set; }
        public string GoodsIssueNo { get; set; }
        public string RefDocumentNo { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public string RouteName { get; set; }
        public string RoundName { get; set; }
        public string ProductId { get; set; }
        public decimal? BinCardReserveQtyBal { get; set; }
        public int? PickingStatus { get; set; }
    }
}
