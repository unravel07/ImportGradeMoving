using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImStockCard
    {
        public Guid StockCardIndex { get; set; }
        public Guid? ProcessIndex { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public Guid? GoodsReceiveIndex { get; set; }
        public Guid GoodsReceiveItemIndex { get; set; }
        public string StockCardNo { get; set; }
        public DateTime? StockCardDate { get; set; }
        public Guid? ProductIndex { get; set; }
        public Guid? ProductIndexTo { get; set; }
        public string ProductLot { get; set; }
        public string ProductLotTo { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public Guid? ItemStatusIndexTo { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public Guid? OwnerIndex { get; set; }
        public Guid? OwnerIndexTo { get; set; }
        public DateTime? GoodsReceiveExpDate { get; set; }
        public DateTime? GoodsReceiveExpDateTo { get; set; }
        public decimal? StockCardQtyIn { get; set; }
        public decimal? StockCardQtyOut { get; set; }
        public decimal? StockCardQtySign { get; set; }
        public decimal? StockCardWeightIn { get; set; }
        public decimal? StockCardWeightOut { get; set; }
        public decimal? StockCardWeightSign { get; set; }
        public decimal? StockCardVolumeIn { get; set; }
        public decimal? StockCardVolumeOut { get; set; }
        public decimal? StockCardVolumeSign { get; set; }
        public Guid? RefDocumentNo { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ImStockCardLock GoodsReceiveItemIndex1 { get; set; }
        public virtual ImGoodsReceiveItem GoodsReceiveItemIndexNavigation { get; set; }
    }
}
