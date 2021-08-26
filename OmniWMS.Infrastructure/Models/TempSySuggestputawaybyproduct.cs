using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class TempSySuggestputawaybyproduct
    {
        public Guid SuggestPutawayByProductIndex { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public Guid LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }
        public int? IsSystem { get; set; }
        public int? StatusId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public decimal? MinStock { get; set; }
        public decimal? MaxStock { get; set; }
    }
}
