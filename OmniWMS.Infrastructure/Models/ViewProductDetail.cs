using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewProductDetail
    {
        public Guid ProductConversionBarcodeIndex { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public Guid ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public decimal ProductConversionRatio { get; set; }
        public decimal? ProductConversionWeight { get; set; }
        public decimal? ProductConversionWidth { get; set; }
        public decimal? ProductConversionLength { get; set; }
        public decimal? ProductConversionHeight { get; set; }
        public decimal ProductConversionVolumeRatio { get; set; }
        public decimal? ProductConversionVolume { get; set; }
        public string ProductConversionBarcodeId { get; set; }
        public string ProductConversionBarcode { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid ProductTypeIndex { get; set; }
        public string ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public Guid ProductSubTypeIndex { get; set; }
        public string ProductSubTypeId { get; set; }
        public string ProductSubTypeName { get; set; }
        public Guid ProductCategoryIndex { get; set; }
        public string ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
        public int? IsExpDate { get; set; }
        public int? IsLot { get; set; }
        public int? IsMfgDate { get; set; }
        public int? ProductItemLifeY { get; set; }
        public int? ProductItemLifeM { get; set; }
        public int? ProductItemLifeD { get; set; }
        public string BaseProductConversion { get; set; }
        public int? IsCatchWeight { get; set; }
    }
}
