using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewInquirySkuConversion
    {
        public long? RowIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductConversionBarcode { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string SkuconversionName { get; set; }
        public string ProductConversionName { get; set; }
        public decimal ProductConversionRatio { get; set; }
    }
}
