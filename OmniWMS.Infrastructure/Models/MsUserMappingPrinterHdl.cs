using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsUserMappingPrinterHdl
    {
        public Guid UsermappingprinterIndex { get; set; }
        public Guid? UserIndex { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string DocumenttypeName { get; set; }
        public string PrinterName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
