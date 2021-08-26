using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImStockCardReserve
    {
        public ImStockCardReserve()
        {
            ImStockCardLock = new HashSet<ImStockCardLock>();
        }

        public Guid StockCardReserveIndex { get; set; }
        public Guid? ProcessIndex { get; set; }
        public Guid? GoodsReceiveIndex { get; set; }
        public Guid? GoodsReceiveItemIndex { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public Guid? OwnerIndex { get; set; }
        public decimal? StockCardReserveQtyBal { get; set; }
        public decimal? StockCardReserveWeightBal { get; set; }
        public decimal? StockCardReserveVolumeBal { get; set; }
        public Guid? RefDocumentNo { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public decimal? StockCardReserveStatus { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }

        public virtual ImGoodsIssueItem RefDocumentItemIndexNavigation { get; set; }
        public virtual ICollection<ImStockCardLock> ImStockCardLock { get; set; }
    }
}
