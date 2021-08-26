using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImPromotions
    {
        public Guid PromotionsIndex { get; set; }
        public Guid? PlanGoodsIssueIndex { get; set; }
        public string PromotionsLink { get; set; }
        public string PromotionsType { get; set; }
        public string PromotionsBarcode { get; set; }
        public decimal? PromotionsAmount { get; set; }
        public string PromotionsApplied { get; set; }
        public decimal? PromotionsCount { get; set; }
        public string PromotionsStep { get; set; }
    }
}
