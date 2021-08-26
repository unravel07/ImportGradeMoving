using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsItemStatus
    {
        public MsItemStatus()
        {
            ImGoodsIssueItem = new HashSet<ImGoodsIssueItem>();
            ImGoodsReceiveItem = new HashSet<ImGoodsReceiveItem>();
            ImGoodsTransferItem = new HashSet<ImGoodsTransferItem>();
            ImPlanGoodsReceiveItem = new HashSet<ImPlanGoodsReceiveItem>();
            ImTransferStockAdjustmentItem = new HashSet<ImTransferStockAdjustmentItem>();
            MsDocumentTypeItemStatus = new HashSet<MsDocumentTypeItemStatus>();
        }

        public Guid ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }
        public int? IsSystem { get; set; }
        public int? StatusId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }

        public virtual ICollection<ImGoodsIssueItem> ImGoodsIssueItem { get; set; }
        public virtual ICollection<ImGoodsReceiveItem> ImGoodsReceiveItem { get; set; }
        public virtual ICollection<ImGoodsTransferItem> ImGoodsTransferItem { get; set; }
        public virtual ICollection<ImPlanGoodsReceiveItem> ImPlanGoodsReceiveItem { get; set; }
        public virtual ICollection<ImTransferStockAdjustmentItem> ImTransferStockAdjustmentItem { get; set; }
        public virtual ICollection<MsDocumentTypeItemStatus> MsDocumentTypeItemStatus { get; set; }
    }
}
