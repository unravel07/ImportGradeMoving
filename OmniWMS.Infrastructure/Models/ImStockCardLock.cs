using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImStockCardLock
    {
        public ImStockCardLock()
        {
            ImStockCard = new HashSet<ImStockCard>();
        }

        public Guid StockCardLockIndex { get; set; }
        public Guid? GoodsReceiveIndex { get; set; }
        public Guid? GoodsReceiveItemIndex { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public Guid? OwnerIndex { get; set; }
        public decimal? StockCardLockQtyBal { get; set; }
        public decimal? StockCardLockWeightBal { get; set; }
        public decimal? StockCardLockVolumeBal { get; set; }
        public Guid StockCardLockKey { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ImStockCardReserve GoodsReceiveItemIndexNavigation { get; set; }
        public virtual ICollection<ImStockCard> ImStockCard { get; set; }
    }
}
