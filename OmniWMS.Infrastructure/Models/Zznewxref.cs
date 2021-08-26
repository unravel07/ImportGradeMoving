using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class Zznewxref
    {
        public double? InptXrefId { get; set; }
        public string Co { get; set; }
        public string Div { get; set; }
        public string BatchId { get; set; }
        public string VendorBrcd { get; set; }
        public double? SkuBrcd { get; set; }
        public double? ScanQnty { get; set; }
        public double? ErrorSeqNbr { get; set; }
        public double? ProcStatCode { get; set; }
        public double? StatCode { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? ModDateTime { get; set; }
        public string UserId { get; set; }
        public string ErrorDesc { get; set; }
    }
}
