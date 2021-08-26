using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ExwmsGradeMovingLog
    {
        public long No { get; set; }
        public long? GradeMovingNo { get; set; }
        public string LogType { get; set; }
        public string BatchNo { get; set; }
        public string RequestData { get; set; }
        public string ResponseData { get; set; }
        public string DocumentStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
