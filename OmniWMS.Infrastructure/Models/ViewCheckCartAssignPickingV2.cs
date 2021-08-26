using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCheckCartAssignPickingV2
    {
        public long? RowIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string GoodsIssueNo { get; set; }
        public string TaskNo { get; set; }
        public string TagOutPickNo { get; set; }
        public string EquipmentItemName { get; set; }
        public string TagoutNo { get; set; }
        public string ProductConversionBarcode { get; set; }
        public string ProductName { get; set; }
        public decimal? Qty { get; set; }
        public decimal? TotalQty { get; set; }
        public decimal? PickingQty { get; set; }
        public decimal? PickingTotalQty { get; set; }
        public string EquipmentId { get; set; }
        public Guid? EquipmentIndex { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentItemId { get; set; }
        public Guid? EquipmentItemIndex { get; set; }
        public string UserAssign { get; set; }
        public string LocationName { get; set; }
        public int? PickingSeq { get; set; }
        public int? PickingStatus { get; set; }
        public int? TagOutPickStatus { get; set; }
        public decimal ConfirmTagOutQty { get; set; }
        public Guid GoodsIssueItemLocationIndex { get; set; }
        public int? GoodIssueItemLocationStatus { get; set; }
        public decimal ProductConversionRatio { get; set; }
    }
}
