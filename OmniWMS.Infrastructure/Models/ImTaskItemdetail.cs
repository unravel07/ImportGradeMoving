using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImTaskItemdetail
    {
        public string TaskNo { get; set; }
        public Guid TaskItemIndex { get; set; }
        public int TaskItemSeq { get; set; }
        public int TaskItemdetailSeq { get; set; }
        public Guid? BinbalanceIndex { get; set; }
        public string WarehouseId { get; set; }
        public string TagNo { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ItemStatusId { get; set; }
        public string LocationId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Ratio { get; set; }
        public decimal? TotalQty { get; set; }
        public string ProductConversionId { get; set; }
        public int? DocumentStatus { get; set; }
        public decimal? PickingQty { get; set; }
        public string ProcessId { get; set; }
        public string RefDocumentNo { get; set; }
        public int? RefLineNo { get; set; }
        public int? RefSeqNo { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public string RefDistroNo { get; set; }
        public int? RefDistroLineNo { get; set; }
        public int? RefDistroSeqNo { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string BatchId { get; set; }
    }
}
