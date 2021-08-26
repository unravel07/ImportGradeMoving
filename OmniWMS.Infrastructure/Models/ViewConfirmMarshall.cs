using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewConfirmMarshall
    {
        public Guid MarshallIndex { get; set; }
        public string MarshallNo { get; set; }
        public int? DocumentStatus { get; set; }
        public decimal? Msqty { get; set; }
        public decimal? MstotalQty { get; set; }
        public decimal? Pqty { get; set; }
        public decimal? PtotaolQty { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundId { get; set; }
        public string RoundName { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string ProcessStatusName { get; set; }
        public string ConfirmMarshallNo { get; set; }
    }
}
