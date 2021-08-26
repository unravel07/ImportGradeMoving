using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewZoneLocation
    {
        public long? RowIndex { get; set; }
        public Guid LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public Guid ZoneIndex { get; set; }
        public string ZoneId { get; set; }
        public string ZoneName { get; set; }
        public Guid LocationTypeIndex { get; set; }
        public string LocationTypeId { get; set; }
        public string LocationTypeName { get; set; }
        public Guid WarehouseIndex { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
    }
}
