using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ExwmsGradeMoving
    {
        public long No { get; set; }
        public string BatchIdIn { get; set; }
        public Guid? BinbalanceIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public Guid? LocationIndex { get; set; }
        public string LocationId { get; set; }
        public decimal? QtyMove { get; set; }
        public Guid? LocationTempIndex { get; set; }
        public string LocationTempId { get; set; }
        public string DocumentStatus { get; set; }
        public Guid? StatusIndex { get; set; }
        public string StatusCode { get; set; }
        public string StatusDesc { get; set; }
        public string BatchIdOut { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
