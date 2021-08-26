using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OmniWMS.Infrastructure.CustomModels
{ 

    public partial class ViewCheckShort
    {
        [Key]
        public Guid PlanGoodsIssue_Index { get; set; }

        public string PlanGoodsIssue_No { get; set; }

        public int? count_zone_order { get; set; }
        public int? count_zone_alloc { get; set; }


    }
}
