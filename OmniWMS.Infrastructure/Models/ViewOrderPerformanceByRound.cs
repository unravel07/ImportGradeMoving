using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewOrderPerformanceByRound
    {
        public long? RowIndex { get; set; }
        public string RoundName { get; set; }
        public DateTime? DocDate { get; set; }
        public int? OrderQty { get; set; }
        public int? DoneQty { get; set; }
        public int? CanceledQty { get; set; }
        public int? RemainQty { get; set; }
    }
}
