using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OverallStatusExpressTemp
    {
        public int? RowIndex { get; set; }
        public string StatusName { get; set; }
        public string DocDate { get; set; }
        public string Qty { get; set; }
    }
}
