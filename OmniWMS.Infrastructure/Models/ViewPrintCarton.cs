using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPrintCarton
    {
        public Guid PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public DateTime PlanGoodsIssueDate { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundId { get; set; }
        public string RoundName { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public DateTime? CreateDate { get; set; }
        public Guid ShipToIndex { get; set; }
        public string ShipToId { get; set; }
        public string ShipToName { get; set; }
        public Guid SoldToIndex { get; set; }
        public string SoldToId { get; set; }
        public string SoldToName { get; set; }
        public int? DocumentStatus { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string PlanGoodsIssueSize { get; set; }
        public decimal? Msqty { get; set; }
        public decimal? MstotalQty { get; set; }
        public int? DocumentStatus1 { get; set; }
        public Guid GoodsIssueIndex { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public string TagOutPickNo { get; set; }
        public Guid? Expr1 { get; set; }
        public string GiCreateBy { get; set; }
        public string GoodsIssueNo { get; set; }
        public string WarehouseName { get; set; }
        public Guid? WarehouseIndex { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeName { get; set; }
    }
}
