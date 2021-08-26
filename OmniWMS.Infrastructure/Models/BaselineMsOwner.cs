using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class BaselineMsOwner
    {
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerAddress { get; set; }
        public Guid OwnerTypeIndex { get; set; }
        public Guid? SubDistrictIndex { get; set; }
        public Guid? DistrictIndex { get; set; }
        public Guid? ProvinceIndex { get; set; }
        public Guid? CountryIndex { get; set; }
        public Guid? PostcodeIndex { get; set; }
        public string OwnerTaxId { get; set; }
        public string OwnerEmail { get; set; }
        public string OwnerFax { get; set; }
        public string OwnerTel { get; set; }
        public string OwnerMobile { get; set; }
        public string OwnerBarcode { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPerson2 { get; set; }
        public string ContactPerson3 { get; set; }
        public string ContactTel { get; set; }
        public string ContactTel2 { get; set; }
        public string ContactTel3 { get; set; }
        public string ContactEmail { get; set; }
        public string ContactEmail2 { get; set; }
        public string ContactEmail3 { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }
        public int? IsSystem { get; set; }
        public int? StatusId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
    }
}
