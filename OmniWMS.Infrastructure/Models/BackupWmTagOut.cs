using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class BackupWmTagOut
    {
        public Guid TagOutIndex { get; set; }
        public string TagOutNo { get; set; }
        public string TagOutRefNo1 { get; set; }
        public string TagOutRefNo2 { get; set; }
        public string TagOutRefNo3 { get; set; }
        public string TagOutRefNo4 { get; set; }
        public string TagOutRefNo5 { get; set; }
        public int? TagOutStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public Guid? ZoneIndex { get; set; }
        public Guid? RefProcessIndex { get; set; }
        public string RefDocumentNo { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public int? IsPrint { get; set; }
        public Guid? LocationConfirmIndex { get; set; }
        public string LocationConfirmId { get; set; }
        public string LocationConfirmName { get; set; }
    }
}
