using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsRule
    {
        public MsRule()
        {
            MsRuleCondition = new HashSet<MsRuleCondition>();
            MsRuleZone = new HashSet<MsRuleZone>();
            MsWaveRule = new HashSet<MsWaveRule>();
        }

        public Guid RuleIndex { get; set; }
        public Guid ProcessIndex { get; set; }
        public string RuleId { get; set; }
        public string RuleName { get; set; }
        public int? RuleSeq { get; set; }
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

        public virtual SyProcess ProcessIndexNavigation { get; set; }
        public virtual ICollection<MsRuleCondition> MsRuleCondition { get; set; }
        public virtual ICollection<MsRuleZone> MsRuleZone { get; set; }
        public virtual ICollection<MsWaveRule> MsWaveRule { get; set; }
    }
}
