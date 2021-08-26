using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class SalesReport
    {
        public string Number { get; set; }
        public DateTime? Date { get; set; }
        public string Customer { get; set; }
        public int? Quantity { get; set; }
    }
}
