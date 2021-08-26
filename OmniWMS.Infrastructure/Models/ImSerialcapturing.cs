using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImSerialcapturing
    {
        public Guid SerialIndex { get; set; }
        public string SerialNo { get; set; }
        public Guid ProcessIndex { get; set; }
        public string ProcessId { get; set; }
        public string ProcessName { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentitemIndex { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string DocumentrefNo1 { get; set; }
        public string DocumentrefNo2 { get; set; }
        public string DocumentrefNo3 { get; set; }
        public string DocumentrefNo4 { get; set; }
        public string DocumentrefNo5 { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public string Status { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
