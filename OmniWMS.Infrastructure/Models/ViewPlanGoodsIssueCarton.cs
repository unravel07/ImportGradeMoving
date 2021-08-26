using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPlanGoodsIssueCarton
    {
        public long? RowIndex { get; set; }
        public Guid? GoodsIssueItemLocationIndex { get; set; }
        public Guid? TagOutPickIndex { get; set; }
        public string TagOutPickNo { get; set; }
        public Guid TagOutIndex { get; set; }
        public string TagOutNo { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid? PlanGoodsIssueItemIndex { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public int? LineNum { get; set; }
        public Guid? ProductIndex { get; set; }
        public int? ProductId { get; set; }
        public int? ProductName { get; set; }
        public int? ProductSecondName { get; set; }
        public int? ProductThirdName { get; set; }
        public int? ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public int? ItemStatusId { get; set; }
        public int? ItemStatusName { get; set; }
        public int? Qty { get; set; }
        public int? Ratio { get; set; }
        public int? TotalQty { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public int? ProductConversionId { get; set; }
        public int? ProductConversionName { get; set; }
        public int? MfgDate { get; set; }
        public int? ExpDate { get; set; }
        public int? UnitWeight { get; set; }
        public int? Weight { get; set; }
        public int? UnitWidth { get; set; }
        public int? UnitLength { get; set; }
        public int? UnitHeight { get; set; }
        public int? UnitVolume { get; set; }
        public int? Volume { get; set; }
        public int? UnitPrice { get; set; }
        public int? Price { get; set; }
        public int? DocumentRefNo1 { get; set; }
        public int? DocumentRefNo2 { get; set; }
        public int? DocumentRefNo3 { get; set; }
        public int? DocumentRefNo4 { get; set; }
        public int? DocumentRefNo5 { get; set; }
        public int? DocumentRemark { get; set; }
        public int DocumentStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public int? Udf3 { get; set; }
        public int? Udf4 { get; set; }
        public int? Udf5 { get; set; }
    }
}
