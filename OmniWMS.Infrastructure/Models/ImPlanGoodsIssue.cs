using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImPlanGoodsIssue
    {
        public ImPlanGoodsIssue()
        {
            Dashboard1 = new HashSet<Dashboard1>();
        }

        public Guid PlanGoodsIssueIndex { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public Guid SoldToIndex { get; set; }
        public string SoldToId { get; set; }
        public string SoldToName { get; set; }
        public string SoldToAddress { get; set; }
        public Guid ShipToIndex { get; set; }
        public string ShipToId { get; set; }
        public string ShipToName { get; set; }
        public string ShipToAddress { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string PlanGoodsIssueNo { get; set; }
        public DateTime PlanGoodsIssueDate { get; set; }
        public DateTime? PlanGoodsIssueDueDate { get; set; }
        public string DocumentRefNo1 { get; set; }
        public string DocumentRefNo2 { get; set; }
        public string DocumentRefNo3 { get; set; }
        public string DocumentRefNo4 { get; set; }
        public string DocumentRefNo5 { get; set; }
        public string DocumentRemark { get; set; }
        public int? DocumentStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public int? DocumentPriorityStatus { get; set; }
        public Guid? WarehouseIndex { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public Guid? WarehouseIndexTo { get; set; }
        public string WarehouseIdTo { get; set; }
        public string WarehouseNameTo { get; set; }
        public Guid? SoldToSubDistrictIndex { get; set; }
        public Guid? SoldToDistrictIndex { get; set; }
        public Guid? SoldToProvinceIndex { get; set; }
        public Guid? SoldToCountryIndex { get; set; }
        public Guid? SoldToPostcodeIndex { get; set; }
        public Guid? SubDistrictIndex { get; set; }
        public Guid? DistrictIndex { get; set; }
        public Guid? ProvinceIndex { get; set; }
        public Guid? CountryIndex { get; set; }
        public Guid? PostcodeIndex { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public int? BackOrderStatus { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundId { get; set; }
        public string RoundName { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteId { get; set; }
        public string RouteName { get; set; }
        public int? PrintTaxInvoice { get; set; }
        public string PaymentType { get; set; }
        public string PaymentCode { get; set; }
        public decimal? CalGrandTotal { get; set; }
        public Guid? ReasonCodeIndex { get; set; }
        public string ReasonCodeId { get; set; }
        public string ReasonCodeName { get; set; }
        public Guid? RefPlanGoodsIssueIndex { get; set; }
        public string RefPlanGoodsIssueNo { get; set; }
        public string StatusRms { get; set; }
        public string StatusDescRms { get; set; }
        public string VendorId { get; set; }
        public DateTime? StplanGoodsIssueDueDate { get; set; }
        public DateTime? CreateDateFile { get; set; }
        public string StatusEdi { get; set; }
        public string StatusReason { get; set; }
        public string RoundTime { get; set; }
        public string WarehousePhone { get; set; }
        public string SoldToT1c { get; set; }
        public string SoldToT1cphone { get; set; }
        public string SoldToEmail { get; set; }
        public string SoldToPhone { get; set; }
        public string ShipToCompanyName { get; set; }
        public string ShipToRemark { get; set; }
        public string ShipToTelephone { get; set; }
        public string ShipToTaxNo { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceCompanyName { get; set; }
        public string InvoiceAddress { get; set; }
        public string InvoiceRemark { get; set; }
        public string InvoiceTelephone { get; set; }
        public string InvoiceTaxNo { get; set; }
        public string PaymentIssuer { get; set; }
        public decimal? CalPromotionDiscount { get; set; }
        public decimal? CalCpn2Discount { get; set; }
        public decimal? CalCpn9Discount { get; set; }
        public decimal? CalEvoucherDiscount { get; set; }
        public decimal? CalTotalAfterDiscount { get; set; }
        public string DocumentRemarkSub { get; set; }
        public string UserAssign { get; set; }
        public string SoldToNameCus { get; set; }
        public string SoldToTel { get; set; }
        public string SoldToEmailCus { get; set; }
        public string SoldToPhoneCus { get; set; }
        public string SoldToAddressCus { get; set; }
        public bool? IsPostPickConfirm { get; set; }
        public DateTime? IsPostPickConfirmDate { get; set; }
        public bool? IsPostShippmentDispatch { get; set; }
        public DateTime? IsPostShippmentDispatchDate { get; set; }
        public string StatusDropSt { get; set; }
        public DateTime? StatusDropStDate { get; set; }
        public string ShipToAddressName { get; set; }
        public string InvoiceAddressName { get; set; }
        public Guid? RefWavePickIndex { get; set; }
        public bool? IsConfirmShipmentFms { get; set; }
        public DateTime? IsConfirmShipmentFmsDate { get; set; }
        public string SubOrderId { get; set; }
        public string CustomInterfaceFlag1 { get; set; }
        public string CustomInterfaceFlag2 { get; set; }
        public string CustomInterfaceFlag3 { get; set; }
        public string CustomInterfaceFlag4 { get; set; }
        public string CustomInterfaceFlag5 { get; set; }

        public virtual MsDocumentType DocumentTypeIndexNavigation { get; set; }
        public virtual MsOwner OwnerIndexNavigation { get; set; }
        public virtual ICollection<Dashboard1> Dashboard1 { get; set; }
    }
}
