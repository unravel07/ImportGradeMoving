using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class TempPackItem
    {
        public string PackNo { get; set; }
        public string Component { get; set; }
        public decimal PackQty { get; set; }
        public string PackItemDesc { get; set; }
        public string ComponentItemDesc { get; set; }
    }
}
