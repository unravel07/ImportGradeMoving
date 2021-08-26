using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class WmTag
    {
        public WmTag()
        {
            WmTagItem = new HashSet<WmTagItem>();
        }

        public Guid TagIndex { get; set; }
        public string TagNo { get; set; }
        public string PalletNo { get; set; }
        public Guid? PalletIndex { get; set; }
        public string TagRefNo1 { get; set; }
        public string TagRefNo2 { get; set; }
        public string TagRefNo3 { get; set; }
        public string TagRefNo4 { get; set; }
        public string TagRefNo5 { get; set; }
        public int? TagStatus { get; set; }
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
        public string UserAssigned { get; set; }

        public virtual ICollection<WmTagItem> WmTagItem { get; set; }
    }
}
