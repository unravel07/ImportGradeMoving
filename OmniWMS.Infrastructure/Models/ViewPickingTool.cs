using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPickingTool
    {
        public Guid MarshallIndex { get; set; }
        public string MarshallNo { get; set; }
        public string OwnerName { get; set; }
        public decimal? Msqty { get; set; }
        public decimal? MstotalQty { get; set; }
        public string RefDocumentNo { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public decimal? QtyBackOrder { get; set; }
        public int? DocumentStatus { get; set; }
        public string ProcessStatusName { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundId { get; set; }
        public string RoundName { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public string PlangoodsissueNo { get; set; }
    }
}
