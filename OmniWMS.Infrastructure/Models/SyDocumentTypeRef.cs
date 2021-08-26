using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class SyDocumentTypeRef
    {
        public Guid DocumentTypeRefIndex { get; set; }
        public Guid ProcessIndex { get; set; }
        public string ProcessId { get; set; }
        public string ProcessName { get; set; }
        public Guid DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public Guid DocumentTypeIndexTo { get; set; }
        public string DocumentTypeIdTo { get; set; }
        public string DocumentTypeNameTo { get; set; }
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
