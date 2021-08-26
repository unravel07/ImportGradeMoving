using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImPrepareData
    {
        public Guid DataIndex { get; set; }
        public DateTime CreateDate { get; set; }
        public string MsgName { get; set; }
        public string SearchKey { get; set; }
        public string DataValues { get; set; }
        public string MsgStatus { get; set; }
        public string MsgDesc { get; set; }
        public string DataPath { get; set; }
    }
}
