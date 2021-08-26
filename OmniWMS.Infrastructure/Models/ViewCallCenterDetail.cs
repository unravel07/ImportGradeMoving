using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCallCenterDetail
    {
        public Guid CallCenterIndex { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string SoNo { get; set; }
        public DateTime? SoDueDate { get; set; }
        public DateTime SoDate { get; set; }
        public DateTime? SoCreatDate { get; set; }
        public string SoldToName { get; set; }
        public string ShipToName { get; set; }
        public int? DocumentStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? ProblemQty { get; set; }
        public decimal? SoQty { get; set; }
        public decimal? CatotalQty { get; set; }
    }
}
