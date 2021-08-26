using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImSalesOrderMappingPos
    {
        public string SalesOrderNo { get; set; }
        public string TpNo { get; set; }
        public string RcptNo { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string TpNoUpdate { get; set; }
        public string RcptNoUpdate { get; set; }
    }
}
