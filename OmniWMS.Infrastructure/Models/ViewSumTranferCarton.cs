using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewSumTranferCarton
    {
        public Guid GoodsIssueIndex { get; set; }
        public decimal? PickingQty { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public Guid? LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string TagOutPickNo { get; set; }
        public string ProductConversionBarcode { get; set; }
    }
}
