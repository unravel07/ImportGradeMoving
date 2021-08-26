using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsProductConversion
    {
        public MsProductConversion()
        {
            ImGoodsIssueItem = new HashSet<ImGoodsIssueItem>();
            ImGoodsReceiveItem = new HashSet<ImGoodsReceiveItem>();
            ImGoodsTransferItem = new HashSet<ImGoodsTransferItem>();
            ImPlanGoodsReceiveItem = new HashSet<ImPlanGoodsReceiveItem>();
            ImPlanGoodsTransferItem = new HashSet<ImPlanGoodsTransferItem>();
            ImTransferStockAdjustmentItem = new HashSet<ImTransferStockAdjustmentItem>();
            MsProductConversionBarcode = new HashSet<MsProductConversionBarcode>();
        }

        public Guid ProductConversionIndex { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public decimal ProductConversionRatio { get; set; }
        public decimal? ProductConversionWeight { get; set; }
        public decimal? ProductConversionWidth { get; set; }
        public decimal? ProductConversionLength { get; set; }
        public decimal? ProductConversionHeight { get; set; }
        public decimal ProductConversionVolumeRatio { get; set; }
        public decimal? ProductConversionVolume { get; set; }
        public int IsActive { get; set; }
        public int IsDelete { get; set; }
        public int IsSystem { get; set; }
        public int StatusId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }

        public virtual ICollection<ImGoodsIssueItem> ImGoodsIssueItem { get; set; }
        public virtual ICollection<ImGoodsReceiveItem> ImGoodsReceiveItem { get; set; }
        public virtual ICollection<ImGoodsTransferItem> ImGoodsTransferItem { get; set; }
        public virtual ICollection<ImPlanGoodsReceiveItem> ImPlanGoodsReceiveItem { get; set; }
        public virtual ICollection<ImPlanGoodsTransferItem> ImPlanGoodsTransferItem { get; set; }
        public virtual ICollection<ImTransferStockAdjustmentItem> ImTransferStockAdjustmentItem { get; set; }
        public virtual ICollection<MsProductConversionBarcode> MsProductConversionBarcode { get; set; }
    }
}
