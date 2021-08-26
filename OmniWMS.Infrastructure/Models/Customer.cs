using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
