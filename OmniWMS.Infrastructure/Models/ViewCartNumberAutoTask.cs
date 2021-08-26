using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCartNumberAutoTask
    {
        public long? RowIndex { get; set; }
        public Guid? TagOutPickIndex { get; set; }
        public string TagOutPickNo { get; set; }
        public Guid? EquipmentIndex { get; set; }
        public string EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public Guid? EquipmentItemIndex { get; set; }
        public string EquipmentItemId { get; set; }
        public string EquipmentItemName { get; set; }
        public string UserAssign { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid? PlanGoodsIssueItemIndex { get; set; }
        public int PickingStatus { get; set; }
        public int TagOutPickStatus { get; set; }
        public Guid TaskIndex { get; set; }
        public string TaskNo { get; set; }
        public Guid TaskItemIndex { get; set; }
    }
}
