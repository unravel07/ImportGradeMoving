using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPickConfirm
    {
        public long? RowIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string SubOrderId { get; set; }
        public string ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public string TaskNo { get; set; }
        public string TagOutPickNo { get; set; }
        public string TagOutNo { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public string ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
    }
}
