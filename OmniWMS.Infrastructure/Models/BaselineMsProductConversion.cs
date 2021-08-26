using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class BaselineMsProductConversion
    {
        public Guid ProductConversionIndex { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public decimal ProductConversionRatio { get; set; }
        public decimal? ProductConversionWeight { get; set; }
        public decimal? ProductConversionWidth { get; set; }
        public decimal? ProductConversionLength { get; set; }
        public decimal? ProductConversionHeight { get; set; }
        public decimal ProductConversionVolumeRatio { get; set; }
        public decimal? ProductConversionVolume { get; set; }
        public int IsActive { get; set; }
        public int IsDelete { get; set; }
        public int IsSystem { get; set; }
        public int StatusId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
