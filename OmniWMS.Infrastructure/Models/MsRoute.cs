using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsRoute
    {
        public MsRoute()
        {
            Dashboard1 = new HashSet<Dashboard1>();
        }

        public Guid RouteIndex { get; set; }
        public Guid SubRouteIndex { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }
        public int? IsSystem { get; set; }
        public int? StatusId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }

        public virtual ICollection<Dashboard1> Dashboard1 { get; set; }
    }
}
