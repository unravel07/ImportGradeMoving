using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewReportPickingSlip
    {
        public string OwnerName { get; set; }
        public string TagOutPickNo { get; set; }
        public string ZoneName { get; set; }
        public string RefDocumentNo { get; set; }
        public string DocumentTypeName { get; set; }
        public string ProductConversionBarcode { get; set; }
        public string ProductName { get; set; }
        public decimal Qty { get; set; }
        public string ProductConversionName { get; set; }
        public string LocationName { get; set; }
        public decimal? QtyPlan { get; set; }
    }
}
