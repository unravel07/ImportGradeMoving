using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ExwmsLogMinimumStock
    {
        public long No { get; set; }
        public string Zone { get; set; }
        public string OrderType { get; set; }
        public string GradeFrom { get; set; }
        public string GradeTo { get; set; }
        public string OrderTypeAgainst { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? MinimumQty { get; set; }
        public decimal? AvailQty { get; set; }
        public decimal? OnOrderQty { get; set; }
        public decimal? AvailDestinationQty { get; set; }
        public decimal? OnOrderDestinationQty { get; set; }
        public decimal? MovingRequestQty { get; set; }
        public string BatchId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
