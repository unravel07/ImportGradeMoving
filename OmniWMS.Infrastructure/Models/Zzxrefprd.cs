using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class Zzxrefprd
    {
        public double? InptXrefId { get; set; }
        public string Co { get; set; }
        public string Div { get; set; }
        public string VendorBrcd { get; set; }
        public string SkuBrcd { get; set; }
        public double? ScanQnty { get; set; }
        public double? ProcStatCode { get; set; }
        public double? StatCode { get; set; }
        public string CreateDateTime { get; set; }
        public string ModDateTime { get; set; }
        public string UserId { get; set; }
        public string AckMsgId { get; set; }
    }
}
