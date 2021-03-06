using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsRouteStoreMaster
    {
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string RoutegroupId { get; set; }
    }
}
