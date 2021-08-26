using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class SyConfigDetail
    {
        public int? ConfigIndex { get; set; }
        public string ConfigKey { get; set; }
        public string ConfigValue { get; set; }
    }
}
