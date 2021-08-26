using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class TempTableExp
    {
        public string Barcode { get; set; }
        public string Mfgdate { get; set; }
        public string Expdate { get; set; }
        public DateTime? MfgdateDate { get; set; }
        public DateTime? ExpdateDate { get; set; }
        public string ProductId { get; set; }
    }
}
