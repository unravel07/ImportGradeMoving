using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsDistroHdr
    {
        public OnwmsDistroHdr()
        {
            OnwmsDistroDtl = new HashSet<OnwmsDistroDtl>();
        }

        public string OwnerId { get; set; }
        public string DistroNo { get; set; }
        public string DocumentstatusId { get; set; }
        public DateTime DueDate { get; set; }
        public string WarehouseId { get; set; }
        public string StoreNo { get; set; }
        public string Remark { get; set; }
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
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string CustomInterfaceFlag1 { get; set; }
        public string BatchId { get; set; }

        public virtual ICollection<OnwmsDistroDtl> OnwmsDistroDtl { get; set; }
    }
}
