using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewWaveRule
    {
        public Guid WaveRuleIndex { get; set; }
        public string WaveRuleId { get; set; }
        public int? WaveRuleSeq { get; set; }
        public Guid WaveIndex { get; set; }
        public string WaveId { get; set; }
        public string WaveName { get; set; }
        public Guid RuleIndex { get; set; }
        public string RuleId { get; set; }
        public string RuleName { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }
        public int? IsSystem { get; set; }
        public int? StatusId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public Guid ProcessIndex { get; set; }
    }
}
