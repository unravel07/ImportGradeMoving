using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewGitablelist
    {
        public long? RowIndex { get; set; }
        public Guid GoodsIssueIndex { get; set; }
        public string GoodsIssueNo { get; set; }
        public string TagOutPickNo { get; set; }
        public DateTime GoodsIssueDate { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public int? DocumentStatus { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid? ShipToIndex { get; set; }
        public string ShipToId { get; set; }
        public string ShipToName { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public string RefDocumentNo { get; set; }
        public string RoundId { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundName { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public Guid? WarehouseIndex { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public Guid? WarehouseIndexTo { get; set; }
        public string WarehouseIdTo { get; set; }
        public string WarehouseNameTo { get; set; }
        public string ProcessStatusName { get; set; }
    }
}
