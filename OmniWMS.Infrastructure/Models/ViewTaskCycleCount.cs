using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewTaskCycleCount
    {
        public Guid TaskIndex { get; set; }
        public string TaskNo { get; set; }
        public Guid CycleCountIndex { get; set; }
        public Guid CycleCountItemIndex { get; set; }
        public string CycleCountNo { get; set; }
        public int? Count { get; set; }
        public Guid? TaskGroupIndex { get; set; }
        public Guid? LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string UserAssign { get; set; }
        public string UserCount { get; set; }
        public int? DocumentStatus { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductSecondName { get; set; }
    }
}
