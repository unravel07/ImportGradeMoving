using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MakeRefGoodsIssueItemLocation
    {
        public long? RowIndex { get; set; }
        public Guid? GoodsIssueIndex { get; set; }
        public Guid GoodsIssueItemIndex { get; set; }
        public Guid? GoodsIssueItemLocationIndex { get; set; }
        public string ProductId { get; set; }
        public Guid? RefProcessIndex { get; set; }
        public string RefDocumentNo { get; set; }
        public string RefDocumentLineNum { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public Guid GoodsReceiveItemIndex { get; set; }
    }
}
