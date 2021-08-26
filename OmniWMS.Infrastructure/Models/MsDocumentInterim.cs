using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsDocumentInterim
    {
        public string DoctypeId { get; set; }
        public string DoctypeName { get; set; }
        public string Prefix { get; set; }
        public int? RunningSize { get; set; }
        public int? LastNumber { get; set; }
    }
}
