using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class SyProcess
    {
        public SyProcess()
        {
            MsDocumentType = new HashSet<MsDocumentType>();
            MsRule = new HashSet<MsRule>();
            SyRuleConditionField = new HashSet<SyRuleConditionField>();
        }

        public Guid ProcessIndex { get; set; }
        public string ProcessId { get; set; }
        public string ProcessName { get; set; }
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

        public virtual ICollection<MsDocumentType> MsDocumentType { get; set; }
        public virtual ICollection<MsRule> MsRule { get; set; }
        public virtual ICollection<SyRuleConditionField> SyRuleConditionField { get; set; }
    }
}
