﻿using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewTagOut
    {
        public Guid TagOutIndex { get; set; }
        public string TagOutNo { get; set; }
        public string TagOutRefNo1 { get; set; }
        public string TagOutRefNo2 { get; set; }
        public string TagOutRefNo3 { get; set; }
        public string TagOutRefNo4 { get; set; }
        public string TagOutRefNo5 { get; set; }
        public int? TagOutStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf4 { get; set; }
        public string Udf3 { get; set; }
        public string Udf5 { get; set; }
        public Guid? ZoneIndex { get; set; }
        public Guid? RefProcessIndex { get; set; }
        public string RefDocumentNo { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public Guid TagOutItemIndex { get; set; }
        public Guid? GoodsIssueIndex { get; set; }
        public Guid? GoodsIssueItemIndex { get; set; }
        public Guid? GoodsIssueItemLocationIndex { get; set; }
        public string CartonNo { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public Guid ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public decimal? Qty { get; set; }
        public decimal Ratio { get; set; }
        public decimal TotalQty { get; set; }
        public Guid ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public string TagOutRefItemNo1 { get; set; }
        public string TagOutRefItemNo2 { get; set; }
        public string TagOutRefItemNo3 { get; set; }
        public string TagOutRefItemNo4 { get; set; }
        public string TagOutRefItemNo5 { get; set; }
        public int? TagOutItemStatus { get; set; }
        public string Udfitem1 { get; set; }
        public string Udfitem2 { get; set; }
        public string Udfitem3 { get; set; }
        public string Udfitem4 { get; set; }
        public string Udfitem5 { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDateItem { get; set; }
    }
}
