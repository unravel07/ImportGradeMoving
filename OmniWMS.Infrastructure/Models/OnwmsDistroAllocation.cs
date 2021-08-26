using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsDistroAllocation
    {
        public string OwnerId { get; set; }
        public string DistroNo { get; set; }
        public int LineNo { get; set; }
        public int SeqNo { get; set; }
        public string BatchId { get; set; }
        public string ProductId { get; set; }
        public string DocumentstatusId { get; set; }
        public Guid BinbalanceIndex { get; set; }
        public string TagNo { get; set; }
        public string StoreNo { get; set; }
        public decimal QtyAllocated { get; set; }
        public decimal WeightAllocated { get; set; }
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
        public Guid? RefGoodsissueitemlocationIndex { get; set; }
        public string RefPoNo { get; set; }
        public Guid? RefPlangoodsreceiveitemIndex { get; set; }
        public string RefPoLine { get; set; }
        public string RefReceiveNo { get; set; }
        public Guid? RefGoodsreceiveitemlocationIndex { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public decimal? Ratio { get; set; }

        public virtual OnwmsDistroDtl OnwmsDistroDtl { get; set; }
    }
}
