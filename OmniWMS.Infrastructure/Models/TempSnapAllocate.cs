using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class TempSnapAllocate
    {
        public string PlangoodsissueNo { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? QtyAllocated { get; set; }
        public decimal? QtyPicked { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
