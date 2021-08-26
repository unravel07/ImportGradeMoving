using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewReportLoadManikest
    {
        public string TruckLoadNo { get; set; }
        public string TruckReg { get; set; }
        public string TruckType { get; set; }
        public string DriverName { get; set; }
        public string DeliveryDate { get; set; }
        public string TruckNo { get; set; }
        public int TotalOrder { get; set; }
        public int? TotalBasket { get; set; }
        public int? CountBasketA { get; set; }
        public int? CountBasketB { get; set; }
        public int? CountBasketC { get; set; }
        public int? CountBasketF { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string ShipToId { get; set; }
        public string ShipToAddress { get; set; }
    }
}
