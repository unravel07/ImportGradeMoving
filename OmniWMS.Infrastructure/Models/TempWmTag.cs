using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class TempWmTag
    {
        public double? IsUse { get; set; }
        public string F2 { get; set; }
        public string TagIndex { get; set; }
        public string TagNo { get; set; }
        public string PalletNo { get; set; }
        public string PalletIndex { get; set; }
        public string TagRefNo1 { get; set; }
        public string TagRefNo2 { get; set; }
        public string TagRefNo3 { get; set; }
        public string TagRefNo4 { get; set; }
        public string TagRefNo5 { get; set; }
        public double? TagStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
