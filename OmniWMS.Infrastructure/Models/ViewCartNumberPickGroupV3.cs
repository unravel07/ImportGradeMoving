using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCartNumberPickGroupV3
    {
        public long? RowIndex { get; set; }
        public string TagOutPickNo { get; set; }
        public string TaskNo { get; set; }
        public Guid TaskIndex { get; set; }
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
        public Guid? LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public decimal PlanRatio { get; set; }
        public Guid? PlanProductConversionIndex { get; set; }
        public string PlanProductConversionId { get; set; }
        public string PlanProductConversionName { get; set; }
        public string ProductConversionBarcode { get; set; }
        public string ImagePicture { get; set; }
        public int PickingSeq { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public string EquipmentItemDesc { get; set; }
        public decimal TotalQty { get; set; }
        public decimal PickingTotalQty { get; set; }
        public decimal? RemainTotalQty { get; set; }
    }
}
