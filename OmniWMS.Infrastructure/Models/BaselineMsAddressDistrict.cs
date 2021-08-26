using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class BaselineMsAddressDistrict
    {
        public Guid DistrictIndex { get; set; }
        public string DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string DistrictNameEn { get; set; }
        public Guid ProvinceIndex { get; set; }
        public Guid CountryIndex { get; set; }
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
