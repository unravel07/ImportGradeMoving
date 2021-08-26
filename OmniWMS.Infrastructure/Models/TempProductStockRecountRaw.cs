using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class TempProductStockRecountRaw
    {
        public string Barcode { get; set; }
        public string RoundSeq { get; set; }
        public string Qty { get; set; }
        public string RecountQty { get; set; }
    }
}
