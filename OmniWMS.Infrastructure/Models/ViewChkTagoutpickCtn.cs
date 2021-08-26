using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewChkTagoutpickCtn
    {
        public long? RowIndex { get; set; }
        public string TagOutPickNo { get; set; }
        public string TagOutNo { get; set; }
        public int? TagOutStatus { get; set; }
        public string UserAssign { get; set; }
    }
}
