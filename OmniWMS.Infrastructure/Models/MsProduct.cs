using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsProduct
    {
        public MsProduct()
        {
            ImGoodsIssueItem = new HashSet<ImGoodsIssueItem>();
            ImGoodsReceiveItem = new HashSet<ImGoodsReceiveItem>();
            ImGoodsTransferItem = new HashSet<ImGoodsTransferItem>();
            ImPlanGoodsReceiveItem = new HashSet<ImPlanGoodsReceiveItem>();
            ImPlanGoodsTransferItem = new HashSet<ImPlanGoodsTransferItem>();
            ImTransferStockAdjustmentItem = new HashSet<ImTransferStockAdjustmentItem>();
            MsProductConversionBarcode = new HashSet<MsProductConversionBarcode>();
            MsProductOwner = new HashSet<MsProductOwner>();
        }

        public Guid ProductIndex { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSecondName { get; set; }
        public string ProductThirdName { get; set; }
        public Guid ProductCategoryIndex { get; set; }
        public Guid ProductConversionIndex { get; set; }
        public string ProductConversionId { get; set; }
        public string ProductConversionName { get; set; }
        public Guid ProductTypeIndex { get; set; }
        public Guid ProductSubTypeIndex { get; set; }
        public int? ProductItemLifeY { get; set; }
        public int? ProductItemLifeM { get; set; }
        public int? ProductItemLifeD { get; set; }
        public string ProductImagePath { get; set; }
        public int? IsLot { get; set; }
        public int? IsExpDate { get; set; }
        public int? IsMfgDate { get; set; }
        public int? IsCatchWeight { get; set; }
        public int? IsPack { get; set; }
        public int? IsSerial { get; set; }
        public int IsActive { get; set; }
        public int IsDelete { get; set; }
        public int IsSystem { get; set; }
        public int StatusId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public string StatusInsertInterface { get; set; }
        public string ErrorInterface { get; set; }
        public string ErrorInterfaceDesc { get; set; }
        public string BatchId { get; set; }
        public int? ProductShelfLifeD { get; set; }
        public string StatusInterface { get; set; }
        public int? RowId { get; set; }
        public int? CustomAttribute1 { get; set; }
        public int? CustomAttribute2 { get; set; }
        public int? CustomAttribute3 { get; set; }
        public int? CustomAttribute4 { get; set; }
        public int? CustomAttribute5 { get; set; }
        public DateTime? CustomAttribute1DateFrom { get; set; }
        public DateTime? CustomAttribute1DateTo { get; set; }
        public string CustomAttributeValue1 { get; set; }
        public int? CustomAttributeInterfaceFlag { get; set; }
        public int? MinimumStock { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public string SubDeptId { get; set; }
        public string SubDeptName { get; set; }
        public string PutawayType { get; set; }
        public int? MlorDay { get; set; }

        public virtual MsProductCategory ProductCategoryIndexNavigation { get; set; }
        public virtual MsProductSubType ProductSubTypeIndexNavigation { get; set; }
        public virtual MsProductType ProductTypeIndexNavigation { get; set; }
        public virtual ICollection<ImGoodsIssueItem> ImGoodsIssueItem { get; set; }
        public virtual ICollection<ImGoodsReceiveItem> ImGoodsReceiveItem { get; set; }
        public virtual ICollection<ImGoodsTransferItem> ImGoodsTransferItem { get; set; }
        public virtual ICollection<ImPlanGoodsReceiveItem> ImPlanGoodsReceiveItem { get; set; }
        public virtual ICollection<ImPlanGoodsTransferItem> ImPlanGoodsTransferItem { get; set; }
        public virtual ICollection<ImTransferStockAdjustmentItem> ImTransferStockAdjustmentItem { get; set; }
        public virtual ICollection<MsProductConversionBarcode> MsProductConversionBarcode { get; set; }
        public virtual ICollection<MsProductOwner> MsProductOwner { get; set; }
    }
}
