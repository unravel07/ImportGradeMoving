using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewConfirmMarshallDetail
    {
        public Guid ConfirmMarshallIndex { get; set; }
        public string ConfirmMarshallNo { get; set; }
        public string OwnerName { get; set; }
        public Guid OwnerIndex { get; set; }
        public string OwnerId { get; set; }
        public Guid? DocumentTypeIndex { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public int? DocumentStatus { get; set; }
        public Guid? WarehouseIndex { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? CmiqtyPlan { get; set; }
        public decimal? Cmiqty { get; set; }
        public decimal? CmitotalQty { get; set; }
    }
}
