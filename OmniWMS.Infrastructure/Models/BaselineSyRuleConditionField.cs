using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class BaselineSyRuleConditionField
    {
        public Guid RuleConditionFieldIndex { get; set; }
        public Guid ProcessIndex { get; set; }
        public string RuleConditionFieldName { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }
        public int? IsSystem { get; set; }
        public int? IsSearch { get; set; }
        public int? IsSort { get; set; }
        public int? IsSource { get; set; }
        public int? IsDestination { get; set; }
        public int? StatusId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
