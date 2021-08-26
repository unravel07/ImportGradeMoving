using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImGoodsTransferItem
    {
        public Guid GoodsTransferItemIndex { get; set; }
        public Guid GoodsTransferIndex { get; set; }
        public Guid? GoodsReceiveIndex { get; set; }
        public Guid? GoodsReceiveItemIndex { get; set; }
        public Guid? GoodsReceiveItemLocationIndex { get; set; }
        public string LineNum { get; set; }
        public Guid? TagItemIndex { get; set; }
        public Guid? TagIndex { get; set; }
        public Guid? TagIndexTo { get; set; }
        public Guid? ProductIndex { get; set; }
        public Guid? ProductIndexTo { get; set; }
        public string ProductLot { get; set; }
        public string ProductLotTo { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public Guid? ItemStatusIndexTo { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public Guid? OwnerIndex { get; set; }
        public Guid? OwnerIndexTo { get; set; }
        public Guid? LocationIndex { get; set; }
        public Guid? LocationIndexTo { get; set; }
        public DateTime? GoodsReceiveExpDate { get; set; }
        public DateTime? GoodsReceiveExpDateTo { get; set; }
        public decimal? Qty { get; set; }
        public decimal? TotalQty { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public Guid? RefProcessIndex { get; set; }
        public string RefDocumentNo { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }

        public virtual ImGoodsTransfer GoodsTransferIndexNavigation { get; set; }
        public virtual MsItemStatus ItemStatusIndexNavigation { get; set; }
        public virtual MsLocation LocationIndexNavigation { get; set; }
        public virtual MsProductConversion ProductConversionIndexNavigation { get; set; }
        public virtual MsProduct ProductIndexNavigation { get; set; }
    }
}
