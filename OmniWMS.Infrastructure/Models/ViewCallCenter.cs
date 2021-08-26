using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCallCenter
    {
        public Guid CallCenterIndex { get; set; }
        public decimal? Ccqty { get; set; }
        public decimal? CctotalQty { get; set; }
        public decimal? CcqtyPlan { get; set; }
        public int? DocumentStatus { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid SoldToIndex { get; set; }
        public string SoldToId { get; set; }
        public string SoldToName { get; set; }
        public Guid ShipToIndex { get; set; }
        public string ShipToId { get; set; }
        public string ShipToName { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundId { get; set; }
        public string RoundName { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public DateTime PlanGoodsIssueDate { get; set; }
        public string ProcessStatusName { get; set; }
        public string ReasonCodeName { get; set; }
        public string ReasonCodeId { get; set; }
        public Guid? ReasonCodeIndex { get; set; }
        public decimal? QtyBackOrder { get; set; }
        public DateTime CallCenterDate { get; set; }
        public decimal? PlanQty { get; set; }
        public string SoldToNameCus { get; set; }
        public string SoldToT1cphone { get; set; }
    }
}
