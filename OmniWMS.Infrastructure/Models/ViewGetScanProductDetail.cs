using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewGetScanProductDetail
    {
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid ProductCategoryIndex { get; set; }
        public Guid ProductTypeIndex { get; set; }
        public Guid ProductSubTypeIndex { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public Guid ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public decimal ProductConversionRatio { get; set; }
        public int? IsExpDate { get; set; }
        public int? IsLot { get; set; }
        public int? IsMfgDate { get; set; }
        public int? IsCatchWeight { get; set; }
        public int? ProductItemLifeY { get; set; }
        public int? ProductItemLifeM { get; set; }
        public int? ProductItemLifeD { get; set; }
        public string BaseProductConversion { get; set; }
        public string GoodsReceiveNo { get; set; }
        public Guid GoodsReceiveIndex { get; set; }
        public Guid GoodsReceiveItemIndex { get; set; }
    }
}
