using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ZzLocationMapping
    {
        public double? Barcode { get; set; }
        public double? Sku { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
