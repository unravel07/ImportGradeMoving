using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class WmBinbalancebackup
    {
        public Guid BinBalanceIndex { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public Guid GoodsReceiveIndex { get; set; }
        public string GoodsReceiveNo { get; set; }
        public DateTime GoodsReceiveDate { get; set; }
        public Guid GoodsReceiveItemIndex { get; set; }
        public Guid GoodsReceiveItemLocationIndex { get; set; }
        public Guid TagItemIndex { get; set; }
        public Guid TagIndex { get; set; }
        public string TagNo { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public Guid ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public DateTime? GoodsReceiveMfgDate { get; set; }
        public DateTime? GoodsReceiveExpDate { get; set; }
        public Guid GoodsReceiveProductConversionIndex { get; set; }
        public string GoodsReceiveProductConversionId { get; set; }
        public string GoodsReceiveProductConversionName { get; set; }
        public decimal? BinBalanceRatio { get; set; }
        public decimal? BinBalanceQtyBegin { get; set; }
        public decimal? BinBalanceWeightBegin { get; set; }
        public decimal? BinBalanceVolumeBegin { get; set; }
        public decimal? BinBalanceQtyBal { get; set; }
        public decimal? BinBalanceWeightBal { get; set; }
        public decimal? BinBalanceVolumeBal { get; set; }
        public decimal? BinBalanceQtyReserve { get; set; }
        public decimal? BinBalanceWeightReserve { get; set; }
        public decimal? BinBalanceVolumeReserve { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
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
        public string IsUse { get; set; }
        public int? BinBalanceStatus { get; set; }
    }
}
