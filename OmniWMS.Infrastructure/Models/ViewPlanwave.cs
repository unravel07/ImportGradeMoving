using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPlanwave
    {
        public Guid? ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public string DocumentRefNo1 { get; set; }
        public string DocumentRefNo2 { get; set; }
        public string DocumentRefNo3 { get; set; }
        public string DocumentRefNo4 { get; set; }
        public string DocumentRefNo5 { get; set; }
        public string DocumentRemark { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public decimal? TotalQty { get; set; }
        public decimal GitotalQty { get; set; }
        public decimal? QtyWave { get; set; }
        public long? RowNum { get; set; }
        public string PlanGoodsIssueUdf1 { get; set; }
        public string PlanGoodsIssueUdf2 { get; set; }
        public string PlanGoodsIssueUdf3 { get; set; }
        public string PlanGoodsIssueUdf4 { get; set; }
        public string PlanGoodsIssueUdf5 { get; set; }
    }
}
