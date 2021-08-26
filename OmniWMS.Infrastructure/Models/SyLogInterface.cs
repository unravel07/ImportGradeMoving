using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class SyLogInterface
    {
        public long LogIndex { get; set; }
        public DateTime LogDate { get; set; }
        public string LogName { get; set; }
        public Guid? DocumentIndex { get; set; }
        public string DocumentNo { get; set; }
        public Guid? DocumentItemIndex { get; set; }
        public string LogRequestbody { get; set; }
        public string LogAbsoluteuri { get; set; }
        public int? LogStatus { get; set; }
    }
}
