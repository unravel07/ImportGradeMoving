using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class WmTaskCycleCount
    {
        public Guid TaskIndex { get; set; }
        public string TaskNo { get; set; }
        public Guid? LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public string UserAssign { get; set; }
        public string UserCount { get; set; }
        public int? DocumentStatus { get; set; }
        public int? Count { get; set; }
        public DateTime? StartCount { get; set; }
        public DateTime? EndCount { get; set; }
        public Guid? TaskGroupIndex { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
