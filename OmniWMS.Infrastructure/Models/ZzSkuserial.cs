using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ZzSkuserial
    {
        public string Store { get; set; }
        public string Dept { get; set; }
        public string Sdept { get; set; }
        public string Class { get; set; }
        public string Sclass { get; set; }
        public string SclasName { get; set; }
        public string Sku { get; set; }
        public string SkuDesc { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double? Onhand { get; set; }
        public double? Available { get; set; }
        public double? PoOnOrd { get; set; }
        public double? ToOnOdr { get; set; }
        public double? AvgCost { get; set; }
        public double? CurCost { get; set; }
        public double? TodaySales { get; set; }
        public double? Reserve { get; set; }
        public double? Allocate { get; set; }
        public double? Intransit { get; set; }
        public double? Hold { get; set; }
        public double? Deposit { get; set; }
    }
}
