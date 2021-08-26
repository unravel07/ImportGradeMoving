using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OverallRoundTemp
    {
        public int? RowIndex { get; set; }
        public string RoundName { get; set; }
        public string DocDate { get; set; }
        public string OrderQty { get; set; }
        public string DoneQty { get; set; }
        public string CanceledQty { get; set; }
        public string RemainQty { get; set; }
    }
}
