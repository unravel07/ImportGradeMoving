using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class TempSnapStock
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? BinBalanceQtyBal { get; set; }
        public decimal? BinBalanceQtyReserve { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
