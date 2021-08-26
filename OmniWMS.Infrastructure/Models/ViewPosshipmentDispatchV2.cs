using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPosshipmentDispatchV2
    {
        public Guid PosIndex { get; set; }
        public string PosNo { get; set; }
        public int? DocumentStatus { get; set; }
        public decimal? QtyPos { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid? OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid? SoldToIndex { get; set; }
        public string SoldToId { get; set; }
        public string SoldToName { get; set; }
        public Guid? ShipToIndex { get; set; }
        public string ShipToId { get; set; }
        public string ShipToName { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundId { get; set; }
        public string RoundName { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public string PaymentType { get; set; }
        public string PaymentCode { get; set; }
        public decimal? CalGrandTotal { get; set; }
        public int? PrintTaxInvoice { get; set; }
        public bool? IsPostPickConfirm { get; set; }
        public bool? IsPostShippmentDispatch { get; set; }
        public decimal? QtySo { get; set; }
        public string ConfirmMarshallNo { get; set; }
        public string ProcessStatusName { get; set; }
    }
}
