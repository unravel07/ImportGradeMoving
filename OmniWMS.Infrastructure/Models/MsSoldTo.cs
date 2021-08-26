using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsSoldTo
    {
        public MsSoldTo()
        {
            MsOwnerSoldTo = new HashSet<MsOwnerSoldTo>();
            MsSoldToShipTo = new HashSet<MsSoldToShipTo>();
        }

        public Guid SoldToIndex { get; set; }
        public string SoldToId { get; set; }
        public string SoldToName { get; set; }
        public string SoldToAddress { get; set; }
        public Guid SoldToTypeIndex { get; set; }
        public Guid? SubDistrictIndex { get; set; }
        public Guid? DistrictIndex { get; set; }
        public Guid? ProvinceIndex { get; set; }
        public Guid? CountryIndex { get; set; }
        public Guid? PostcodeIndex { get; set; }
        public string SoldToTaxId { get; set; }
        public string SoldToEmail { get; set; }
        public string SoldToFax { get; set; }
        public string SoldToTel { get; set; }
        public string SoldToMobile { get; set; }
        public string SoldToBarcode { get; set; }
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
        public string StatusInterface { get; set; }
        public DateTime? SoldToOpen { get; set; }
        public DateTime? SoldToClose { get; set; }
        public string SoldToSource { get; set; }

        public virtual MsSoldToType SoldToTypeIndexNavigation { get; set; }
        public virtual ICollection<MsOwnerSoldTo> MsOwnerSoldTo { get; set; }
        public virtual ICollection<MsSoldToShipTo> MsSoldToShipTo { get; set; }
    }
}
