using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class Zzitemprd
    {
        public double? InptItemMasterId { get; set; }
        public string Co { get; set; }
        public string Div { get; set; }
        public string SizeDesc { get; set; }
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
        public string EccnNbr { get; set; }
        public string OrgnCertCode { get; set; }
        public string ProdCatgry { get; set; }
        public string CreateDateTime { get; set; }
        public string ModDateTime { get; set; }
        public string UserId { get; set; }
        public string SplInstr1 { get; set; }
    }
}
