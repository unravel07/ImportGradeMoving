using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsDocumentType
    {
        public MsDocumentType()
        {
            ImGoodsIssue = new HashSet<ImGoodsIssue>();
            ImGoodsReceive = new HashSet<ImGoodsReceive>();
            ImGoodsTransfer = new HashSet<ImGoodsTransfer>();
            ImPlanGoodsIssue = new HashSet<ImPlanGoodsIssue>();
            ImPlanGoodsReceive = new HashSet<ImPlanGoodsReceive>();
            ImPlanGoodsTransfer = new HashSet<ImPlanGoodsTransfer>();
            ImTransferStockAdjustment = new HashSet<ImTransferStockAdjustment>();
            MsDocumentTypeItemStatus = new HashSet<MsDocumentTypeItemStatus>();
            MsDocumentTypeNumber = new HashSet<MsDocumentTypeNumber>();
        }

        public Guid DocumentTypeIndex { get; set; }
        public Guid? ProcessIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string FormatText { get; set; }
        public string FormatDate { get; set; }
        public string FormatRunning { get; set; }
        public string FormatDocument { get; set; }
        public int? IsResetByYear { get; set; }
        public int? IsResetByMonth { get; set; }
        public int? IsResetByDay { get; set; }
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

        public virtual SyProcess ProcessIndexNavigation { get; set; }
        public virtual ICollection<ImGoodsIssue> ImGoodsIssue { get; set; }
        public virtual ICollection<ImGoodsReceive> ImGoodsReceive { get; set; }
        public virtual ICollection<ImGoodsTransfer> ImGoodsTransfer { get; set; }
        public virtual ICollection<ImPlanGoodsIssue> ImPlanGoodsIssue { get; set; }
        public virtual ICollection<ImPlanGoodsReceive> ImPlanGoodsReceive { get; set; }
        public virtual ICollection<ImPlanGoodsTransfer> ImPlanGoodsTransfer { get; set; }
        public virtual ICollection<ImTransferStockAdjustment> ImTransferStockAdjustment { get; set; }
        public virtual ICollection<MsDocumentTypeItemStatus> MsDocumentTypeItemStatus { get; set; }
        public virtual ICollection<MsDocumentTypeNumber> MsDocumentTypeNumber { get; set; }
    }
}
