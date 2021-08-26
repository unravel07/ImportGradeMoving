using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPreparePrintCartonRf
    {
        public long? RowIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public string TagOutPickNo { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentItemName { get; set; }
        public string SuggestLocationName { get; set; }
        public int? TagOutPickStatus { get; set; }
        public decimal ConfirmTagOutQty { get; set; }
    }
}
