using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ExwmsMonitorMaster
    {
        public string MonitorId { get; set; }
        public string StationId { get; set; }
        public string RefLocationId { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string RefStoreId { get; set; }
        public string RefPutawayType { get; set; }
        public string Udf1 { get; set; }
        public string BaseStationId { get; set; }
        public string Row { get; set; }
        public string RowPrefix { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual OnwmsStoreStaging RefLocation { get; set; }
        public virtual OnwmsStationMaster Station { get; set; }
    }
}
