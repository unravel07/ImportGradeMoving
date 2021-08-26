using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsProductType
    {
        public MsProductType()
        {
            MsProduct = new HashSet<MsProduct>();
            MsProductSubType = new HashSet<MsProductSubType>();
        }

        public Guid ProductTypeIndex { get; set; }
        public string ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public Guid ProductCategoryIndex { get; set; }
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

        public virtual ICollection<MsProduct> MsProduct { get; set; }
        public virtual ICollection<MsProductSubType> MsProductSubType { get; set; }
    }
}
