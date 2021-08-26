using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewInquiryLocationDetails
    {
        public long? RowIndex { get; set; }
        public string LocationName { get; set; }
        public string LocationTypeName { get; set; }
        public string ZoneName { get; set; }
        public string LocationWorkAreaId { get; set; }
        public string LocationBay { get; set; }
        public string LocationDepth { get; set; }
        public string LocationLevel { get; set; }
        public string PutAwaySeq { get; set; }
        public string PickingSeq { get; set; }
    }
}
