using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OverallStatusExpress
    {
        public int RowIndex { get; set; }
        public string StatusName { get; set; }
        public DateTime? DocDate { get; set; }
        public string Qty { get; set; }
    }
}
