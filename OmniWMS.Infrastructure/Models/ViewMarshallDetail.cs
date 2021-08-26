using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewMarshallDetail
    {
        public string MarshallNo { get; set; }
        public string OwnerName { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public Guid? WarehouseIndex { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public decimal? Msqty { get; set; }
        public decimal? MstotalQty { get; set; }
    }
}
