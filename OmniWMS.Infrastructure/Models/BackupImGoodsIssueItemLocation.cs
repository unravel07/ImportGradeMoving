using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class BackupImGoodsIssueItemLocation
    {
        public Guid GoodsIssueItemLocationIndex { get; set; }
        public Guid GoodsIssueItemIndex { get; set; }
        public Guid GoodsIssueIndex { get; set; }
        public string LineNum { get; set; }
        public Guid? TagItemIndex { get; set; }
        public Guid? TagIndex { get; set; }
        public string TagNo { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public Guid? LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public decimal Qty { get; set; }
        public decimal Ratio { get; set; }
        public decimal TotalQty { get; set; }
        public Guid ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public decimal? UnitWeight { get; set; }
        public decimal Weight { get; set; }
        public decimal UnitWidth { get; set; }
        public decimal UnitLength { get; set; }
        public decimal UnitHeight { get; set; }
        public decimal UnitVolume { get; set; }
        public decimal Volume { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }
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
        public string RefDocumentNo { get; set; }
        public string RefDocumentLineNum { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public Guid GoodsReceiveItemIndex { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public int? PickingStatus { get; set; }
        public string PickingBy { get; set; }
        public DateTime? PickingDate { get; set; }
        public string PickingRef1 { get; set; }
        public string PickingRef2 { get; set; }
        public decimal? PickingQty { get; set; }
        public decimal? PickingRatio { get; set; }
        public decimal? PickingTotalQty { get; set; }
        public Guid? PickingProductConversionIndex { get; set; }
        public int? MashallStatus { get; set; }
        public decimal? MashallQty { get; set; }
        public int? CancelStatus { get; set; }
    }
}
