using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewInquiryPutawaySuggestionLocation
    {
        public long? RowIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductSecondName { get; set; }
        public string LocationName { get; set; }
        public string ZoneName { get; set; }
        public string PutAwaySeq { get; set; }
    }
}
