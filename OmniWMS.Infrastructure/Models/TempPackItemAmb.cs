using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class TempPackItemAmb
    {
        public string Pack { get; set; }
        public string PackSize { get; set; }
        public string Loose { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string LocationName { get; set; }
        public string PackWms { get; set; }
        public string PackSizeWms { get; set; }
        public string LooseWms { get; set; }
    }
}
