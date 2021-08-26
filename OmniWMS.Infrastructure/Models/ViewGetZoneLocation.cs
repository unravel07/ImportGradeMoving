using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewGetZoneLocation
    {
        public Guid ZoneLocationIndex { get; set; }
        public string ZoneLocationId { get; set; }
        public Guid? ZoneIndex { get; set; }
        public string ZoneName { get; set; }
        public Guid? LocationIndex { get; set; }
        public string LocationName { get; set; }
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
    }
}
