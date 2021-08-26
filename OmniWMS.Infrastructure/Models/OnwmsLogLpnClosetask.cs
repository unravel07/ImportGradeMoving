using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsLogLpnClosetask
    {
        public long LogId { get; set; }
        public string OwnerId { get; set; }
        public Guid TaskIndex { get; set; }
        public string TaskNo { get; set; }
        public string LineNum { get; set; }
        public Guid TaskItemIndex { get; set; }
        public Guid? TagIndex { get; set; }
        public string TagNo { get; set; }
        public string BatchId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
