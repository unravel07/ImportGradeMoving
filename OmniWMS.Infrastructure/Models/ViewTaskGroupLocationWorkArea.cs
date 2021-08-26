using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewTaskGroupLocationWorkArea
    {
        public Guid TaskGroupIndex { get; set; }
        public string TaskGroupId { get; set; }
        public string TaskGroupName { get; set; }
        public Guid TaskGroupWorkAreaIndex { get; set; }
        public string TaskGroupWorkAreaId { get; set; }
        public Guid WorkAreaIndex { get; set; }
        public string WorkAreaId { get; set; }
        public string WorkAreaName { get; set; }
        public int? TaskIsActive { get; set; }
        public int? TaskGroupWorkAreaIsActive { get; set; }
        public int? WorkAreaIsActive { get; set; }
    }
}
