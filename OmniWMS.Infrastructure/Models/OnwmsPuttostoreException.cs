using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsPuttostoreException
    {
        public long No { get; set; }
        public string DistroNo { get; set; }
        public int? LineNo { get; set; }
        public string DistrodtlStatus { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? QtyPut { get; set; }
        public string StatusId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
