using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImGoodsIssueWaveAllocation
    {
        public string OwnerId { get; set; }
        public string GoodsIssueNo { get; set; }
        public string PlangoodsissueNo { get; set; }
        public string DocumentStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
