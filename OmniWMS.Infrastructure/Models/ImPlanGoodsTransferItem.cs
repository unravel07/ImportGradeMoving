using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImPlanGoodsTransferItem
    {
        public Guid PlanGoodsTransferItemIndex { get; set; }
        public Guid PlanGoodsTransferIndex { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Ratio { get; set; }
        public decimal? TotalQty { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public decimal? UnitWeight { get; set; }
        public decimal? Weight { get; set; }
        public decimal? UnitVolume { get; set; }
        public decimal? Volume { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Price { get; set; }
        public Guid? WarehouseIndex { get; set; }
        public Guid? WarehouseIndexTo { get; set; }
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
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }

        public virtual ImPlanGoodsTransfer PlanGoodsTransferIndexNavigation { get; set; }
        public virtual MsProductConversion ProductConversionIndexNavigation { get; set; }
        public virtual MsProduct ProductIndexNavigation { get; set; }
    }
}
