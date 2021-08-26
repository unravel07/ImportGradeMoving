using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsLogResendShipment
    {
        public long? No { get; set; }
        public string OrderNo { get; set; }
        public int? Frequency { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
