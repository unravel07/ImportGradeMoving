using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsVendor
    {
        public MsVendor()
        {
            ImPlanGoodsReceive = new HashSet<ImPlanGoodsReceive>();
            MsOwnerVendor = new HashSet<MsOwnerVendor>();
        }

        public Guid VendorIndex { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public Guid VendorTypeIndex { get; set; }
        public Guid SubDistrictIndex { get; set; }
        public Guid DistrictIndex { get; set; }
        public Guid ProvinceIndex { get; set; }
        public Guid CountryIndex { get; set; }
        public Guid PostcodeIndex { get; set; }
        public string VendorTaxId { get; set; }
        public string VendorEmail { get; set; }
        public string VendorFax { get; set; }
        public string VendorTel { get; set; }
        public string VendorMobile { get; set; }
        public string VendorBarcode { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPerson2 { get; set; }
        public string ContactPerson3 { get; set; }
        public string ContactTel { get; set; }
        public string ContactTel2 { get; set; }
        public string ContactTel3 { get; set; }
        public string ContactEmail { get; set; }
        public string ContactEmail2 { get; set; }
        public string ContactEmail3 { get; set; }
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
        public string Udf1 { get; set; }

        public virtual MsVendorType VendorTypeIndexNavigation { get; set; }
        public virtual ICollection<ImPlanGoodsReceive> ImPlanGoodsReceive { get; set; }
        public virtual ICollection<MsOwnerVendor> MsOwnerVendor { get; set; }
    }
}
