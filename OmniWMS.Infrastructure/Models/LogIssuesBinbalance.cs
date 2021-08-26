using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class LogIssuesBinbalance
    {
        public long No { get; set; }
        public Guid? PlangoodsissueIndex { get; set; }
        public Guid? PlangoodsissueitemIndex { get; set; }
        public Guid? MarshalltaskIndex { get; set; }
        public Guid? MarshalltaskitemIndex { get; set; }
        public string PlangoodsissueNo { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? QtyBeginShortchase { get; set; }
        public decimal? DeductedQty { get; set; }
        public Guid? DeductedBinbalanceIndex { get; set; }
        public Guid? DeductedLocationIndex { get; set; }
        public Guid? ProcessIndex { get; set; }
        public string ProcessRemark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
