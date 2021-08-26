using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImTransferStockAdjustment
    {
        public ImTransferStockAdjustment()
        {
            ImTransferStockAdjustmentItem = new HashSet<ImTransferStockAdjustmentItem>();
        }

        public Guid StockAdjustmentIndex { get; set; }
        public Guid OwnerIndex { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string StockAdjustmentNo { get; set; }
        public DateTime StockAdjustmentDate { get; set; }
        public string DocumentRefNo1 { get; set; }
        public string DocumentRefNo2 { get; set; }
        public string DocumentRefNo3 { get; set; }
        public string DocumentRefNo4 { get; set; }
        public string DocumentRefNo5 { get; set; }
        public int? DocumentStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public int? DocumentPriorityStatus { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public Guid? ReasonCodeIndex { get; set; }
        public string ReasonCodeId { get; set; }
        public string ReasonCodeName { get; set; }

        public virtual MsDocumentType DocumentTypeIndexNavigation { get; set; }
        public virtual MsOwner OwnerIndexNavigation { get; set; }
        public virtual ICollection<ImTransferStockAdjustmentItem> ImTransferStockAdjustmentItem { get; set; }
    }
}
