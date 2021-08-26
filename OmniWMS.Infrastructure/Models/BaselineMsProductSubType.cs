using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class BaselineMsProductSubType
    {
        public Guid ProductSubTypeIndex { get; set; }
        public string ProductSubTypeId { get; set; }
        public string ProductSubTypeName { get; set; }
        public Guid ProductTypeIndex { get; set; }
        public int IsActive { get; set; }
        public int IsDelete { get; set; }
        public int IsSystem { get; set; }
        public int StatusId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
