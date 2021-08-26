using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewStgOutptInvsnap
    {
        public long? RowIndex { get; set; }
        public string SystemId { get; set; }
        public decimal? WmsFfcBatchId { get; set; }
        public int? DxsBatchId { get; set; }
        public decimal? SeqNo { get; set; }
        public decimal? ProcStatCode { get; set; }
        public string Whse { get; set; }
        public string Co { get; set; }
        public string Div { get; set; }
        public string SkuId { get; set; }
        public int? Season { get; set; }
        public int? SeasonYr { get; set; }
        public int? Style { get; set; }
        public int? StyleSfx { get; set; }
        public int? Color { get; set; }
        public int? ColorSfx { get; set; }
        public int? SecDim { get; set; }
        public int? Qual { get; set; }
        public string SizeDesc { get; set; }
        public int? SizeRangeCode { get; set; }
        public int? SizeRelPosnInTable { get; set; }
        public string SkuBrcd { get; set; }
        public int? BatchNbr { get; set; }
        public decimal? SohQty { get; set; }
        public int? HoldQty { get; set; }
        public int? StdSubPackQty { get; set; }
        public int? StdPackQty { get; set; }
        public int? StdCaseQty { get; set; }
        public DateTime DateProc { get; set; }
        public string SysUserId { get; set; }
    }
}
