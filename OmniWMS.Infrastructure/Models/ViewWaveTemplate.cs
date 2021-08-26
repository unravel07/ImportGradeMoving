using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewWaveTemplate
    {
        public Guid WaveIndex { get; set; }
        public string WaveId { get; set; }
        public string WaveName { get; set; }
        public string WaveRuleId { get; set; }
        public int? WaveRuleSeq { get; set; }
        public Guid WaveRuleIndex { get; set; }
        public Guid ProcessIndex { get; set; }
        public string ProcessId { get; set; }
        public string ProcessName { get; set; }
        public Guid RuleIndex { get; set; }
        public string RuleId { get; set; }
        public string RuleName { get; set; }
        public int? RuleSeq { get; set; }
        public Guid RuleConditionFieldIndex { get; set; }
        public string RuleConditionFieldName { get; set; }
        public Guid RuleConditionOperationIndex { get; set; }
        public string RuleConditionOperationType { get; set; }
        public string RuleConditionOperation { get; set; }
        public Guid RuleConditionIndex { get; set; }
        public string RuleConditionParam { get; set; }
        public int? RuleConditionSeq { get; set; }
        public int? IsSearch { get; set; }
        public int? IsSort { get; set; }
        public int? IsSource { get; set; }
        public int? IsDestination { get; set; }
        public long? RowIndex { get; set; }
    }
}
