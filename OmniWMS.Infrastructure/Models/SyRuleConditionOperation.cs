using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class SyRuleConditionOperation
    {
        public SyRuleConditionOperation()
        {
            MsRuleCondition = new HashSet<MsRuleCondition>();
        }

        public Guid RuleConditionOperationIndex { get; set; }
        public Guid RuleConditionFieldIndex { get; set; }
        public string RuleConditionOperationType { get; set; }
        public string RuleConditionOperation { get; set; }
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

        public virtual SyRuleConditionField RuleConditionFieldIndexNavigation { get; set; }
        public virtual ICollection<MsRuleCondition> MsRuleCondition { get; set; }
    }
}
