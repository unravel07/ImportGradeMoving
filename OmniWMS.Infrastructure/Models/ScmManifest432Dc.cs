using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ScmManifest432Dc
    {
        public string Whse { get; set; }
        public decimal CdMasterId { get; set; }
        public string Co { get; set; }
        public string Div { get; set; }
        public string LoadNbr { get; set; }
        public string Bol { get; set; }
        public string ShpmtNbr { get; set; }
        public string ShipVia { get; set; }
        public string CustPoNbr { get; set; }
        public string PltId { get; set; }
        public string CartonNbr { get; set; }
        public string SizeDesc { get; set; }
        public string SkuDesc { get; set; }
        public string Units { get; set; }
        public decimal SubPack { get; set; }
        public string PktCtrlNbr { get; set; }
        public string CustomerOrder { get; set; }
        public DateTime? LastInvcDateTime { get; set; }
        public decimal? CartonQty { get; set; }
        public string DistroNbr { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Weight { get; set; }
        public decimal? QtyShip { get; set; }
        public decimal ProcStatCode { get; set; }
        public decimal? CrcBatchId { get; set; }
        public DateTime? CrcBatchDateTime { get; set; }
        public decimal PId { get; set; }
    }
}
