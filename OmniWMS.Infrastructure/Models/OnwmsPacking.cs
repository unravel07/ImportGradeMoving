using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsPacking
    {
        public string OwnerId { get; set; }
        public string PackStationId { get; set; }
        public Guid PlanGoodsIssueIndex { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public bool? IsMain { get; set; }
        public string TagOutNo { get; set; }
        public Guid? TagOutIndex { get; set; }
        public int? PackItemNo { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
