using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewInquiryTask
    {
        public long? RowIndex { get; set; }
        public string TaskNo { get; set; }
        public string ProcessName { get; set; }
        public string TaskGroupName { get; set; }
        public string RefDocumentNo { get; set; }
        public string SubRefDocumentNo { get; set; }
        public string RemarkDocument { get; set; }
        public string LocationName { get; set; }
        public string ZoneName { get; set; }
        public string ProductId { get; set; }
        public string ProductSecondName { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public decimal TaskQty { get; set; }
        public decimal TaskRatio { get; set; }
        public decimal TaskTotalQty { get; set; }
        public decimal PickingQty { get; set; }
        public decimal PickingRatio { get; set; }
        public decimal PickingTotalQty { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public string BackOrderStatus { get; set; }
        public decimal? QtyBackOrder { get; set; }
        public string TaskStatus { get; set; }
    }
}
