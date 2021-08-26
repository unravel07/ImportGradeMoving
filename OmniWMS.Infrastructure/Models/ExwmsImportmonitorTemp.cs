using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ExwmsImportmonitorTemp
    {
        public long No { get; set; }
        public string Id { get; set; }
        public string Zone { get; set; }
        public string Row { get; set; }
        public string RowPrefix { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string OperCode { get; set; }
        public string IsOver { get; set; }
        public string PutawayType { get; set; }
        public DateTime? CreateDateRaw { get; set; }
        public string CreateByRaw { get; set; }
        public string StatusCode { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorDesc { get; set; }
        public string LocationId { get; set; }
        public string BatchId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
