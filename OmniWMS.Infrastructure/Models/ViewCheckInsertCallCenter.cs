using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCheckInsertCallCenter
    {
        public long? RowIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string LineNum { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public decimal? PlanQty { get; set; }
        public decimal? PlanRatio { get; set; }
        public decimal? PlanTotalQty { get; set; }
        public decimal? TotalBackOrder { get; set; }
        public int ReplaceStatus { get; set; }
        public decimal? PickingTotalQty { get; set; }
        public decimal? MarshallTaskPickTotalQty { get; set; }
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
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public decimal UnitHeight { get; set; }
        public decimal UnitLength { get; set; }
        public decimal UnitWidth { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitWeight { get; set; }
        public decimal UnitVolume { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public Guid PlanGoodsIssueItemIndex { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
    }
}
