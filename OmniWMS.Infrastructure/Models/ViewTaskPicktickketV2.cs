using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewTaskPicktickketV2
    {
        public long? RowIndex { get; set; }
        public Guid TaskIndex { get; set; }
        public string GoodsIssueNo { get; set; }
        public Guid GoodsIssueIndex { get; set; }
        public Guid GoodsIssueItemLocationIndex { get; set; }
        public Guid? RefProcessIndex { get; set; }
        public string RefDocumentNo { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public Guid? ZoneIndex { get; set; }
        public Guid TaskItemIndex { get; set; }
        public string ZoneId { get; set; }
        public string ZoneName { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public string ProductSubTypeId { get; set; }
        public string ProductSubTypeName { get; set; }
    }
}
