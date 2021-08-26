using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewBinBalance
    {
        public long? RowIndex { get; set; }
        public Guid BinBalanceIndex { get; set; }
        public Guid TagIndex { get; set; }
        public string TagNo { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public DateTime? GoodsReceiveExpDate { get; set; }
        public decimal? BinBalanceQtyBal { get; set; }
        public decimal? BinBalanceRatio { get; set; }
        public decimal? BinBalanceQtyReserve { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public Guid ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
    }
}
