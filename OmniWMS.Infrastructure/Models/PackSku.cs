using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class PackSku
    {
        public string SkuNumber { get; set; }
        public decimal? PackSize { get; set; }
        public string PackSglItemBarcode { get; set; }
    }
}
