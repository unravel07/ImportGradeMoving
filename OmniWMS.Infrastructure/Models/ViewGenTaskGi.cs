using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewGenTaskGi
    {
        public Guid GoodsIssueIndex { get; set; }
        public Guid GoodsIssueItemIndex { get; set; }
        public Guid GoodsIssueItemLocationIndex { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string GoodsIssueNo { get; set; }
        public DateTime GoodsIssueDate { get; set; }
        public Guid? TagItemIndex { get; set; }
        public Guid? TagIndex { get; set; }
        public string TagNo { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public Guid? LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public decimal Qty { get; set; }
        public decimal Ratio { get; set; }
        public decimal TotalQty { get; set; }
        public Guid ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public string RefDocumentNo { get; set; }
        public string RefDocumentLineNum { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public Guid ProductSubTypeIndex { get; set; }
        public string ProductSubTypeId { get; set; }
        public string ProductSubTypeName { get; set; }
        public Guid ProductTypeIndex { get; set; }
        public string ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public Guid ZoneIndex { get; set; }
        public string ZoneId { get; set; }
        public string ZoneName { get; set; }
        public Guid? WorkAreaIndex { get; set; }
        public string WorkAreaId { get; set; }
        public string WorkAreaName { get; set; }
        public int? IsPack { get; set; }
        public Guid? WarehouseIndex { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
    }
}
