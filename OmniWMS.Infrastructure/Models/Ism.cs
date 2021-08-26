using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class Ism
    {
        public string Sku { get; set; }
        public string Location { get; set; }
        public decimal? Qty { get; set; }
    }
}
