using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class TempPosDeduct
    {
        public string ProductId { get; set; }
        public string ProductSecondName { get; set; }
        public string PackUnit { get; set; }
        public string SmallestUnit { get; set; }
        public string Transfer { get; set; }
        public string QtyDeductStock { get; set; }
    }
}
