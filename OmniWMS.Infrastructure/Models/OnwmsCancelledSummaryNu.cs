using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsCancelledSummaryNu
    {
        public long No { get; set; }
        public string OwnerId { get; set; }
        public string OrderNo { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal TotalQtyCancelled { get; set; }
        public decimal? TotalQtyClear { get; set; }
        public string UomCancelled { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
