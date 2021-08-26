using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ExwmsImportGradeMovingTemp
    {
        public long No { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string GradeFrom { get; set; }
        public string GradeTo { get; set; }
        public decimal? FromAvailQty { get; set; }
        public decimal? FromOnOrderQty { get; set; }
        public decimal? ToAvailQty { get; set; }
        public decimal? ToOnOrderQty { get; set; }
        public decimal? FromTotalAvail { get; set; }
        public decimal? ToTotalAvail { get; set; }
        public decimal? MoveQty { get; set; }
        public string DocumentStatus { get; set; }
        public string StatusCode { get; set; }
        public string StatusDesc { get; set; }
        public string BatchId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
