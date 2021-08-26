using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewTaskDetail
    {
        public Guid TaskIndex { get; set; }
        public string TaskNo { get; set; }
        public string LocationId { get; set; }
        public Guid? LocationIndex { get; set; }
        public string LocationName { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public decimal? TaskQty { get; set; }
        public decimal? TaskTotalQty { get; set; }
        public int? DocumentStatus { get; set; }
        public int? DocumentPriorityStatus { get; set; }
    }
}
