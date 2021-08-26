using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPosdetail
    {
        public Guid PosIndex { get; set; }
        public string PosNo { get; set; }
        public Guid PositemIndex { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public Guid? PlanGoodsIssueItemIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public string PaymentCode { get; set; }
        public string PaymentType { get; set; }
        public decimal? CalGrandTotal { get; set; }
        public string ProductConversionBarcode { get; set; }
        public string UserAssign { get; set; }
        public int? PrintTaxInvoice { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
