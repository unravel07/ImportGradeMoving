using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ExwmsLogMoveGradeRequest
    {
        public long No { get; set; }
        public string MoveType { get; set; }
        public Guid? BinbalanceIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? MovingRequestQty { get; set; }
        public decimal? ActualRequestQty { get; set; }
        public string GradeFrom { get; set; }
        public string GradeTo { get; set; }
        public string Zone { get; set; }
        public string OrderType { get; set; }
        public string OrderTypeAgainst { get; set; }
        public string DocumentStatus { get; set; }
        public string StatusCode { get; set; }
        public string StatusDesc { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string BatchIdIn { get; set; }
        public string BatchIdOut { get; set; }
    }
}
