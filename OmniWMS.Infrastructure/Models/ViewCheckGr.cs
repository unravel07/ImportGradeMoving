using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCheckGr
    {
        public Guid PlanGoodsReceiveIndex { get; set; }
        public Guid? OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid? VendorIndex { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string PlanGoodsReceiveNo { get; set; }
        public DateTime? PlanGoodsReceiveDate { get; set; }
        public DateTime? PlanGoodsReceiveDueDate { get; set; }
        public string DocumentRefNo1 { get; set; }
        public string DocumentRefNo2 { get; set; }
        public string DocumentRefNo3 { get; set; }
        public string DocumentRefNo4 { get; set; }
        public string DocumentRefNo5 { get; set; }
        public int? DocumentStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public int? DocumentPriorityStatus { get; set; }
        public string DocumentRemark { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public Guid? WarehouseIndex { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public Guid? WarehouseIndexTo { get; set; }
        public string WarehouseIdTo { get; set; }
        public string WarehouseNameTo { get; set; }
        public Guid PlanGoodsReceiveItemIndex { get; set; }
        public Guid? Expr1 { get; set; }
        public string LineNum { get; set; }
        public Guid? ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public Guid? ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Ratio { get; set; }
        public decimal? TotalQty { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public decimal? UnitWeight { get; set; }
        public decimal? Weight { get; set; }
        public decimal? UnitWidth { get; set; }
        public decimal? UnitLength { get; set; }
        public decimal? UnitHeight { get; set; }
        public decimal? UnitVolume { get; set; }
        public decimal? Volume { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Price { get; set; }
        public string Expr2 { get; set; }
        public string Expr3 { get; set; }
        public string Expr4 { get; set; }
        public string Expr5 { get; set; }
        public string Expr6 { get; set; }
        public int? Expr7 { get; set; }
        public string Expr8 { get; set; }
        public string Expr9 { get; set; }
        public string Expr10 { get; set; }
        public string Expr11 { get; set; }
        public string Expr12 { get; set; }
        public string Expr13 { get; set; }
        public string Expr14 { get; set; }
        public DateTime? Expr15 { get; set; }
        public string Expr16 { get; set; }
        public DateTime? Expr17 { get; set; }
        public string Expr18 { get; set; }
        public DateTime? Expr19 { get; set; }
        public Guid GoodsReceiveItemIndex { get; set; }
        public Guid GoodsReceiveIndex { get; set; }
        public string Expr20 { get; set; }
        public Guid Expr21 { get; set; }
        public string Expr22 { get; set; }
        public string Expr23 { get; set; }
        public string Expr24 { get; set; }
        public string Expr25 { get; set; }
        public string Expr26 { get; set; }
        public Guid Expr27 { get; set; }
        public string Expr28 { get; set; }
        public string Expr29 { get; set; }
        public decimal? QtyPlan { get; set; }
        public decimal Expr30 { get; set; }
        public decimal Expr31 { get; set; }
        public decimal Expr32 { get; set; }
        public Guid Expr33 { get; set; }
        public string Expr34 { get; set; }
        public string Expr35 { get; set; }
        public Guid? PalletIndex { get; set; }
        public DateTime? Expr36 { get; set; }
        public DateTime? Expr37 { get; set; }
        public decimal? Expr38 { get; set; }
        public decimal Expr39 { get; set; }
        public decimal Expr40 { get; set; }
        public decimal Expr41 { get; set; }
        public decimal Expr42 { get; set; }
        public decimal Expr43 { get; set; }
        public decimal Expr44 { get; set; }
        public decimal Expr45 { get; set; }
        public decimal Expr46 { get; set; }
        public string Expr47 { get; set; }
        public string Expr48 { get; set; }
        public string Expr49 { get; set; }
        public string Expr50 { get; set; }
        public string Expr51 { get; set; }
        public int? Expr52 { get; set; }
        public string Expr53 { get; set; }
        public string Expr54 { get; set; }
        public string Expr55 { get; set; }
        public string Expr56 { get; set; }
        public string Expr57 { get; set; }
        public Guid? RefProcessIndex { get; set; }
        public string RefDocumentNo { get; set; }
        public string RefDocumentLineNum { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public Guid? RefDocumentItemIndex { get; set; }
        public string GoodsReceiveRemark { get; set; }
        public string GoodsReceiveDockDoor { get; set; }
        public string Expr58 { get; set; }
        public DateTime? Expr59 { get; set; }
        public string Expr60 { get; set; }
        public DateTime? Expr61 { get; set; }
        public string Expr62 { get; set; }
        public DateTime? Expr63 { get; set; }
        public string UserAssign { get; set; }
        public string UserAssignKey { get; set; }
    }
}
