using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImStockBalance
    {
        public Guid StockBalanceIndex { get; set; }
        public Guid? OwnerIndex { get; set; }
        public Guid? GoodsReceiveIndex { get; set; }
        public Guid? GoodsReceiveItemIndex { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public DateTime? GoodsReceiveMfgDate { get; set; }
        public DateTime? GoodsReceiveExpDate { get; set; }
        public Guid? GoodsReceiveProductConversionIndex { get; set; }
        public decimal? StockBalanceRatio { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public decimal? StockBalanceQtyBegin { get; set; }
        public decimal? StockBalanceWeightBegin { get; set; }
        public decimal? StockBalanceVolumeBegin { get; set; }
        public decimal? StockBalanceQtyBal { get; set; }
        public decimal? StockBalanceWeightBal { get; set; }
        public decimal? StockBalanceVolumeBal { get; set; }
        public decimal? StockBalanceQtyReserve { get; set; }
        public decimal? StockBalanceWeightReserve { get; set; }
        public decimal? StockBalanceVolumeReserve { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
