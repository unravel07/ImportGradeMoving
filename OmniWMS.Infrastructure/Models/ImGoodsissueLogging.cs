using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImGoodsissueLogging
    {
        public long No { get; set; }
        public string GoodsIssueNo { get; set; }
        public string State { get; set; }
        public string RuleId { get; set; }
        public string RuleName { get; set; }
        public string ReferenceNo1 { get; set; }
        public string ReferenceNo2 { get; set; }
        public string ReferenceNo3 { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
