using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ShortWave1
    {
        public string ProductId { get; set; }
        public string LocationName { get; set; }
        public string ProductCategoryName { get; set; }
        public string Group { get; set; }
        public string ProductSecondName { get; set; }
        public double? Count { get; set; }
        public string F7 { get; set; }
    }
}
