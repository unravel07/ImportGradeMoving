using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class OnwmsStoreMaster
    {
        public OnwmsStoreMaster()
        {
            OnwmsStorePacking = new HashSet<OnwmsStorePacking>();
        }

        public string OwnerId { get; set; }
        public string StoreNo { get; set; }
        public string WarehouseId { get; set; }
        public string StoreName { get; set; }
        public string StoreChkDigit { get; set; }
        public string StoreAddress { get; set; }
        public string StoreSubdistrictId { get; set; }
        public string StoreDistrictId { get; set; }
        public string StoreProvinceId { get; set; }
        public string StorePostcode { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public bool? DeliverySun { get; set; }
        public bool? DeliveryMon { get; set; }
        public bool? DeliveryTue { get; set; }
        public bool? DeliveryWed { get; set; }
        public bool? DeliveryThu { get; set; }
        public bool? DeliveryFri { get; set; }
        public bool? DeliverySat { get; set; }
        public string Remark { get; set; }
        public string RouteId { get; set; }
        public bool? IsActive { get; set; }
        public int? PriorityNo { get; set; }
        public bool? IsNewstore { get; set; }
        public bool? IsFranchise { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int? DeliveryLeadtimeDay { get; set; }
        public int? DeliveryLeadtimeMinutes { get; set; }

        public virtual ICollection<OnwmsStorePacking> OnwmsStorePacking { get; set; }
    }
}
