using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsProductspecialtagLastTemp
    {
        public Guid? ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondname { get; set; }
        public string TagType { get; set; }
        public string TagKey { get; set; }
        public string TagValue { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
