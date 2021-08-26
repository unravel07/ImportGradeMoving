using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class WmBinCard
    {
        public Guid BinCardIndex { get; set; }
        public Guid? ProcessIndex { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public Guid? GoodsReceiveIndex { get; set; }
        public Guid? GoodsReceiveItemIndex { get; set; }
        public Guid? GoodsReceiveItemLocationIndex { get; set; }
        public string BinCardNo { get; set; }
        public DateTime? BinCardDate { get; set; }
        public Guid? TagItemIndex { get; set; }
        public Guid? TagIndex { get; set; }
        public string TagNo { get; set; }
        public Guid? TagIndexTo { get; set; }
        public string TagNoTo { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public Guid? ProductIndexTo { get; set; }
        public string ProductIdTo { get; set; }
        public string ProductNameTo { get; set; }
        public string ProductSecondNameTo { get; set; }
        public string ProductThirdNameTo { get; set; }
        public string ProductLot { get; set; }
        public string ProductLotTo { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public Guid? ItemStatusIndexTo { get; set; }
        public string ItemStatusIdTo { get; set; }
        public string ItemStatusNameTo { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public Guid? OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid? OwnerIndexTo { get; set; }
        public string OwnerIdTo { get; set; }
        public string OwnerNameTo { get; set; }
        public Guid? LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public Guid? LocationIndexTo { get; set; }
        public string LocationIdTo { get; set; }
        public string LocationNameTo { get; set; }
        public DateTime? GoodsReceiveExpDate { get; set; }
        public DateTime? GoodsReceiveExpDateTo { get; set; }
        public decimal? BinCardQtyIn { get; set; }
        public decimal? BinCardQtyOut { get; set; }
        public decimal? BinCardQtySign { get; set; }
        public decimal? BinCardWeightIn { get; set; }
        public decimal? BinCardWeightOut { get; set; }
        public decimal? BinCardWeightSign { get; set; }
        public decimal? BinCardVolumeIn { get; set; }
        public decimal? BinCardVolumeOut { get; set; }
        public decimal? BinCardVolumeSign { get; set; }
        public string RefDocumentNo { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public string TagOutItemIndex { get; set; }
        public Guid? TagOutIndex { get; set; }
        public string TagOutNo { get; set; }
        public Guid? TagOutIndexTo { get; set; }
        public string TagOutNoTo { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CustomInterfaceFlag1 { get; set; }
        public string CustomInterfaceFlag2 { get; set; }
        public string CustomInterfaceFlag3 { get; set; }
        public string CustomInterfaceFlag4 { get; set; }
        public string CustomInterfaceFlag5 { get; set; }
    }
}
