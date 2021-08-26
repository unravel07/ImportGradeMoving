using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class Zznewitem
    {
        public double? InptItemMasterId { get; set; }
        public string Co { get; set; }
        public string Div { get; set; }
        public string BatchId { get; set; }
        public string SkuNumber { get; set; }
        public string ProdGroup { get; set; }
        public string ProdSubGrp { get; set; }
        public string SkuDesc { get; set; }
        public double? StdPackQty { get; set; }
        public double? StdBundlQty { get; set; }
        public double? StdPltQty { get; set; }
        public double? ProdLifeInDay { get; set; }
        public string AllowRcptOlderSku { get; set; }
        public double? MaxRecvToXpireDays { get; set; }
        public double? StatCode { get; set; }
        public string SkuBrcd { get; set; }
        public double? StdSubPackQty { get; set; }
        public string ConsPrtyDateCode { get; set; }
        public string SkuStatus { get; set; }
        public string EccnNbr { get; set; }
        public string OrgnCertCode { get; set; }
        public string ProdCatgry { get; set; }
        public string CreateDateTime { get; set; }
        public string ModDateTime { get; set; }
        public string UserId { get; set; }
        public string VendorId { get; set; }
        public string ProdCatgryName { get; set; }
        public string ProdSubGrpName { get; set; }
        public string ProdGroupName { get; set; }
        public double? ProcStatCode { get; set; }
        public double? ErrorSeqNbr { get; set; }
    }
}
