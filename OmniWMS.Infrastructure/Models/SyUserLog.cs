using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class SyUserLog
    {
        public Guid UserLogIndex { get; set; }
        public Guid UserIndex { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public Guid UserKey { get; set; }
        public int? StatusId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
