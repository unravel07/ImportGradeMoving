using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OverallRoundPickTemp
    {
        public int? RowIndex { get; set; }
        public string RoundName { get; set; }
        public string DocDate { get; set; }
        public string PickQty { get; set; }
        public string Fulfilled { get; set; }
        public string UnFulfilled { get; set; }
        public string Remain { get; set; }
    }
}
