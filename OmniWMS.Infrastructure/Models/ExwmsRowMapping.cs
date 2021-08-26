using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ExwmsRowMapping
    {
        public long No { get; set; }
        public string Aisle { get; set; }
        public string Row { get; set; }
        public int? Seq { get; set; }
    }
}
