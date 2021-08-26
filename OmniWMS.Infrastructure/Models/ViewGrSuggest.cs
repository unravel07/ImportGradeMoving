using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewGrSuggest
    {
        public Guid GoodsReceiveIndex { get; set; }
        public Guid GoodsReceiveItemIndex { get; set; }
        public Guid GoodsReceiveItemLocationIndex { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string GoodsReceiveNo { get; set; }
        public DateTime GoodsReceiveDate { get; set; }
        public string LineNum { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public Guid? TagItemIndex { get; set; }
        public Guid? TagIndex { get; set; }
        public string TagNo { get; set; }
        public string ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public decimal? UnitWeight { get; set; }
        public decimal? Weight { get; set; }
        public decimal? UnitWidth { get; set; }
        public decimal? UnitLength { get; set; }
        public decimal? UnitHeight { get; set; }
        public decimal? UnitVolume { get; set; }
        public decimal? Volume { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Price { get; set; }
        public Guid? LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public decimal? Qty { get; set; }
        public decimal Ratio { get; set; }
        public decimal TotalQty { get; set; }
        public int? PutawayStatus { get; set; }
        public int? DocumentStatus { get; set; }
        public string RefDocumentNo { get; set; }
        public string RefDocumentLineNum { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public int? GridocumentStatus { get; set; }
    }
}
