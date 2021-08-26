using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class WmBinCardLock
    {
        public Guid BinCardLockIndex { get; set; }
        public Guid? GoodsReceiveIndex { get; set; }
        public Guid? GoodsReceiveItemIndex { get; set; }
        public Guid? TagItemIndex { get; set; }
        public Guid? TagIndex { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public Guid? OwnerIndex { get; set; }
        public Guid? LocationIndex { get; set; }
        public decimal? BinCardLockQtyBal { get; set; }
        public decimal? BinCardLockWeightBal { get; set; }
        public decimal? BinCardLockVolumeBal { get; set; }
        public Guid BinCardLockKey { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
