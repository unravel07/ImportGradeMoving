using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewMsUser
    {
        public Guid UserIndex { get; set; }
        public Guid UserGroupIndex { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
