using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class BackupViewPreparePrintCartonRf
    {
        public long? RowIndex { get; set; }
        public Guid GoodsIssueIndex { get; set; }
        public string GoodsIssueNo { get; set; }
        public Guid? EquipmentIndex { get; set; }
        public string EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentItemId { get; set; }
        public Guid? EquipmentItemIndex { get; set; }
        public string EquipmentItemName { get; set; }
        public Guid? TagOutPickIndex { get; set; }
        public string TagOutPickNo { get; set; }
        public string SuggestLocationName { get; set; }
        public string TagOutNo { get; set; }
        public int? TagOutStatus { get; set; }
        public int? DocumentStatus { get; set; }
        public Guid? LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public Guid GoodsIssueItemLocationIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
    }
}
