using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class BaselineMsDocumentType
    {
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
    }
}
