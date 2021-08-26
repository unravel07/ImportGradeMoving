using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPlanGipopUpSearch
    {
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
        public string ProcessStatusName { get; set; }
        public string UserAssign { get; set; }
    }
}
