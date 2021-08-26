using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewSumQtyBinbalance
    {
        public long? RowIndex { get; set; }
        public string LocationName { get; set; }
        public decimal? BinBalanceQtyBal { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public Guid OwnerIndex { get; set; }
        public Guid WarehouseIndex { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
    }
}
