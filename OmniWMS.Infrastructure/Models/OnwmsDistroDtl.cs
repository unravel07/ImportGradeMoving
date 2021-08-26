using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsDistroDtl
    {
        public OnwmsDistroDtl()
        {
            OnwmsDistroAllocation = new HashSet<OnwmsDistroAllocation>();
        }

        public string OwnerId { get; set; }
        public string DistroNo { get; set; }
        public int LineNo { get; set; }
        public string DocumentstatusId { get; set; }
        public string ProductId { get; set; }
        public decimal Qty { get; set; }
        public decimal? QtyAllocated { get; set; }
        public decimal? QtyFulfilled { get; set; }
        public decimal? Weight { get; set; }
        public decimal? WeightAllocated { get; set; }
        public string ReferencePoNo { get; set; }
        public int? ReferencePoSeq { get; set; }
        public string ReferenceNo12 { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public string ReferenceNo1 { get; set; }
        public string ReferenceNo2 { get; set; }
        public string ReferenceNo3 { get; set; }
        public string ReferenceNo4 { get; set; }
        public string ReferenceNo5 { get; set; }
        public string Remark { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public decimal? Ratio { get; set; }
        public string BatchId { get; set; }

        public virtual OnwmsDistroHdr OnwmsDistroHdr { get; set; }
        public virtual ICollection<OnwmsDistroAllocation> OnwmsDistroAllocation { get; set; }
    }
}
