using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewUserTaskGroup
    {
        public long? RowNumber { get; set; }
        public Guid UserIndex { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public Guid TaskGroupIndex { get; set; }
        public string TaskGroupId { get; set; }
        public string TaskGroupName { get; set; }
        public Guid TaskGroupUserIndex { get; set; }
        public string TaskGroupUserId { get; set; }
    }
}
