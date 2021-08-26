using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsShipTo
    {
        public MsShipTo()
        {
            MsSoldToShipTo = new HashSet<MsSoldToShipTo>();
        }

        public Guid ShipToIndex { get; set; }
        public string ShipToId { get; set; }
        public string ShipToName { get; set; }
        public string ShipToAddress { get; set; }
        public Guid ShipToTypeIndex { get; set; }
        public Guid? SubDistrictIndex { get; set; }
        public Guid? DistrictIndex { get; set; }
        public Guid? ProvinceIndex { get; set; }
        public Guid? CountryIndex { get; set; }
        public Guid? PostcodeIndex { get; set; }
        public string ShipToTaxId { get; set; }
        public string ShipToEmail { get; set; }
        public string ShipToFax { get; set; }
        public string ShipToTel { get; set; }
        public string ShipToMobile { get; set; }
        public string ShipToBarcode { get; set; }
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

        public virtual MsShipToType ShipToTypeIndexNavigation { get; set; }
        public virtual ICollection<MsSoldToShipTo> MsSoldToShipTo { get; set; }
    }
}
