using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class LogUpdateBalanceCatchweight
    {
        public Guid? BinBalanceIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? BinBalanceQtyBal { get; set; }
        public decimal? BinBalanceQtyReserve { get; set; }
        public DateTime? CreateDate { get; set; }
        public Guid? BinBalanceIndexTo { get; set; }
        public decimal? OldQtybal { get; set; }
        public decimal? OldQtyres { get; set; }
    }
}
