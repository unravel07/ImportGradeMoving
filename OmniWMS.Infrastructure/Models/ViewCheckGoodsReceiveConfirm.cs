﻿using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewCheckGoodsReceiveConfirm
    {
        public Guid GoodsReceiveIndex { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string GoodsReceiveNo { get; set; }
        public DateTime GoodsReceiveDate { get; set; }
        public string DocumentRefNo1 { get; set; }
        public string DocumentRefNo2 { get; set; }
        public string DocumentRefNo3 { get; set; }
        public string DocumentRefNo4 { get; set; }
        public string DocumentRefNo5 { get; set; }
        public int? DocumentStatus { get; set; }
        public string DocumentRemark { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public int? DocumentPriorityStatus { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public int? PutawayStatus { get; set; }
        public Guid? WarehouseIndex { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public Guid? WarehouseIndexTo { get; set; }
        public string WarehouseIdTo { get; set; }
        public string WarehouseNameTo { get; set; }
        public Guid? DockDoorIndex { get; set; }
        public string DockDoorId { get; set; }
        public string DockDoorName { get; set; }
        public Guid? VehicleTypeIndex { get; set; }
        public string VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }
        public Guid? ContainerTypeIndex { get; set; }
        public string ContainerTypeId { get; set; }
        public string ContainerTypeName { get; set; }
        public Guid BinBalanceIndex { get; set; }
        public Guid Expr1 { get; set; }
        public string Expr2 { get; set; }
        public string Expr3 { get; set; }
        public Guid LocationIndex { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public Guid Expr4 { get; set; }
        public string Expr5 { get; set; }
        public DateTime Expr6 { get; set; }
        public Guid GoodsReceiveItemIndex { get; set; }
        public Guid GoodsReceiveItemLocationIndex { get; set; }
        public Guid TagItemIndex { get; set; }
        public Guid TagIndex { get; set; }
        public string TagNo { get; set; }
        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public string ProductLot { get; set; }
        public Guid ItemStatusIndex { get; set; }
        public string ItemStatusId { get; set; }
        public string ItemStatusName { get; set; }
        public DateTime? GoodsReceiveMfgDate { get; set; }
        public DateTime? GoodsReceiveExpDate { get; set; }
        public Guid GoodsReceiveProductConversionIndex { get; set; }
        public string GoodsReceiveProductConversionId { get; set; }
        public string GoodsReceiveProductConversionName { get; set; }
        public decimal? BinBalanceRatio { get; set; }
        public decimal? BinBalanceQtyBegin { get; set; }
        public decimal? BinBalanceWeightBegin { get; set; }
        public decimal? BinBalanceVolumeBegin { get; set; }
        public decimal? BinBalanceQtyBal { get; set; }
        public decimal? BinBalanceWeightBal { get; set; }
        public decimal? BinBalanceVolumeBal { get; set; }
        public decimal? BinBalanceQtyReserve { get; set; }
        public decimal? BinBalanceWeightReserve { get; set; }
        public decimal? BinBalanceVolumeReserve { get; set; }
        public Guid? ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public string Expr7 { get; set; }
        public string Expr8 { get; set; }
        public string Expr9 { get; set; }
        public string Expr10 { get; set; }
        public string Expr11 { get; set; }
        public string Expr12 { get; set; }
        public DateTime? Expr13 { get; set; }
        public string Expr14 { get; set; }
        public DateTime? Expr15 { get; set; }
        public string Expr16 { get; set; }
        public DateTime? Expr17 { get; set; }
        public string IsUse { get; set; }
        public int? BinBalanceStatus { get; set; }
    }
}