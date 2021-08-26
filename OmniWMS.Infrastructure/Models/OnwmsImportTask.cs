using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsImportTask
    {
        public long Id { get; set; }
        public Guid TaskNo { get; set; }
        public string FileName { get; set; }
        public string Status { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
