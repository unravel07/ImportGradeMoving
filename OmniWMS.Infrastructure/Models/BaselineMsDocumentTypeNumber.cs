using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class BaselineMsDocumentTypeNumber
    {
        public Guid DocumentTypeNumberIndex { get; set; }
        public Guid DocumentTypeIndex { get; set; }
        public string DocumentTypeNumberYear { get; set; }
        public string DocumentTypeNumberMonth { get; set; }
        public string DocumentTypeNumberDay { get; set; }
        public int? DocumentTypeNumberRunning { get; set; }
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
