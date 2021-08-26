using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewGoodsIssue
    {
        public Guid GoodsIssueIndex { get; set; }
        public string GoodsIssueNo { get; set; }
        public int? DocumentStatus { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public string GiCreateBy { get; set; }
    }
}
