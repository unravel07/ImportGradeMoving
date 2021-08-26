using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewConfirmDoc
    {
        public Guid? GoodsReceiveIndex { get; set; }
        public Guid? GoodsReceiveItemIndex { get; set; }
        public Guid? ProductIndex { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Ratio { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public Guid PlanGoodsReceiveIndex { get; set; }
    }
}
