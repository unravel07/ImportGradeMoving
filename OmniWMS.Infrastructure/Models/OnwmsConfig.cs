using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsConfig
    {
        public long No { get; set; }
        public string ConfigIssue { get; set; }
        public string ConfigGroupKey { get; set; }
        public string ConfigKey { get; set; }
        public string ConfigValue { get; set; }
        public bool? IsEnabled { get; set; }
        public string Remark { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
