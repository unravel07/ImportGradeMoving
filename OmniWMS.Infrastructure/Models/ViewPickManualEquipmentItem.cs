using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewPickManualEquipmentItem
    {
        public long? RowId { get; set; }
        public Guid? RefDocumentIndex { get; set; }
        public string EquipmentItemName { get; set; }
    }
}
