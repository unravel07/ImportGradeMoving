using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCheckUserAssign
    {
        public long? RowIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string GoodsIssueNo { get; set; }
        public string UserAssign { get; set; }
        public string TaskNo { get; set; }
        public string TagOutPickNo { get; set; }
        public string TagoutNo { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentItemId { get; set; }
        public string EquipmentItemName { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int? TagOutStatus { get; set; }
    }
}
