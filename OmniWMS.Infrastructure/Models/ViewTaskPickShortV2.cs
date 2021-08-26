using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewTaskPickShortV2
    {
        public Guid RowIndex { get; set; }
        public Guid MarshallIndex { get; set; }
        public string MarshallNo { get; set; }
        public Guid MarshallTaskIndex { get; set; }
        public Guid MarshallTaskItemIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public Guid? PlanGoodsIssueItemIndex { get; set; }
        public int? DocumentStatus { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductName { get; set; }
        public string ProductId { get; set; }
        public string ProductSecondName { get; set; }
        public decimal Count { get; set; }
        public decimal? QtyBackOrder { get; set; }
        public decimal PickingTotalQty { get; set; }
        public int ReplaceStatus { get; set; }
        public string LocationName { get; set; }
        public string Udf2 { get; set; }
        public decimal ProductConversionRatio { get; set; }
        public Guid ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public string ProductConversionBarcode { get; set; }
        public string Image { get; set; }
        public string TagType { get; set; }
        public string TagKey { get; set; }
        public string TagValue { get; set; }
        public string IsWeightByPiece { get; set; }
        public decimal? QtyRemark { get; set; }
    }
}
