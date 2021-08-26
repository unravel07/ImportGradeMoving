using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class WmBinCardReserve
    {
        public Guid BinCardReserveIndex { get; set; }
        public Guid? BinBalanceIndex { get; set; }
        public Guid? ProcessIndex { get; set; }
        public Guid? GoodsReceiveIndex { get; set; }
        public string GoodsReceiveNo { get; set; }
        public DateTime? GoodsReceiveDate { get; set; }
        public Guid? GoodsReceiveItemIndex { get; set; }
        public Guid? TagItemIndex { get; set; }
        public Guid? TagIndex { get; set; }
        public string TagNo { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public Guid? OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid? LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public decimal? BinCardReserveQtyBal { get; set; }
        public decimal? BinCardReserveWeightBal { get; set; }
        public decimal? BinCardReserveVolumeBal { get; set; }
        public string RefDocumentNo { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public string RefWaveIndex { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public int? BinCardReserveStatus { get; set; }
    }
}
