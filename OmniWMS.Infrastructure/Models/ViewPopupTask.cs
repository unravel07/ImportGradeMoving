using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPopupTask
    {
        public Guid GoodsIssueIndex { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid TaskIndex { get; set; }
        public Guid? LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string TagKey { get; set; }
    }
}
