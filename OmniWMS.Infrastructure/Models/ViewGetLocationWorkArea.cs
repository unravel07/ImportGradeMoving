using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewGetLocationWorkArea
    {
        public Guid LocationWorkAreaIndex { get; set; }
        public string LocationWorkAreaId { get; set; }
        public Guid LocationIndex { get; set; }
        public string LocationName { get; set; }
        public Guid WorkAreaIndex { get; set; }
        public string WorkAreaName { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }
        public int? StatusId { get; set; }
        public int? IsSystem { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
