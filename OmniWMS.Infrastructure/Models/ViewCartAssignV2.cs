using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCartAssignV2
    {
        public Guid TagOutPickIndex { get; set; }
        public string TagOutPickNo { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public Guid TagOutIndex { get; set; }
        public string TagOutNo { get; set; }
    }
}
