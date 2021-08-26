using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewSumQtyLocation
    {
        public long? RowIndex { get; set; }
        public string LocationName { get; set; }
        public decimal? BinBalanceQtyBal { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public Guid OwnerIndex { get; set; }
        public string LocationId { get; set; }
        public Guid LocationIndex { get; set; }
        public decimal? BinBalanceQtyReserve { get; set; }
    }
}
