using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewGetIdPickingTool
    {
        public Guid MarshallTaskIndex { get; set; }
        public string MarshallTaskNo { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string UserAssign { get; set; }
        public Guid MarshallTaskItemIndex { get; set; }
        public string LineNum { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public Guid ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public decimal TotalQty { get; set; }
        public decimal? QtyBackOrder { get; set; }
        public decimal? PickingQty { get; set; }
        public decimal? PickingTotalQty { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public string RefDocumentNo { get; set; }
        public decimal? UnitWeight { get; set; }
        public decimal Weight { get; set; }
        public decimal UnitWidth { get; set; }
        public decimal UnitLength { get; set; }
        public decimal UnitHeight { get; set; }
        public decimal UnitVolume { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }
        public decimal Volume { get; set; }
        public string DocumentRefNo1 { get; set; }
        public string DocumentRefNo2 { get; set; }
        public string DocumentRefNo3 { get; set; }
        public string DocumentRefNo4 { get; set; }
        public string DocumentRefNo5 { get; set; }
        public int? DocumentStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public Guid? RefProcessIndex { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public string MarshallTaskRemark { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public int? ReplaceStatus { get; set; }
        public decimal? Count { get; set; }
        public string LocationName { get; set; }
        public string ProductConversionId { get; set; }
        public Guid ProductConversionIndex { get; set; }
        public string ProductConversionName { get; set; }
        public string ProductConversionBarcode { get; set; }
        public decimal ProductConversionRatio { get; set; }
        public string Image { get; set; }
    }
}
