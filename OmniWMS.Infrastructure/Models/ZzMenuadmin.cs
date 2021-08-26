using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ZzMenuadmin
    {
        public string UserGroupMenuIndex { get; set; }
        public double? UserGroupMenuId { get; set; }
        public string UserGroupIndex { get; set; }
        public string MenuIndex { get; set; }
        public double? IsActive { get; set; }
        public double? IsDelete { get; set; }
        public double? IsSystem { get; set; }
        public double? StatusId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
