﻿using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsEquipmentType
    {
        public MsEquipmentType()
        {
            MsEquipment = new HashSet<MsEquipment>();
            MsEquipmentSubType = new HashSet<MsEquipmentSubType>();
        }

        public Guid EquipmentTypeIndex { get; set; }
        public string EquipmentTypeId { get; set; }
        public string EquipmentTypeName { get; set; }
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

        public virtual ICollection<MsEquipment> MsEquipment { get; set; }
        public virtual ICollection<MsEquipmentSubType> MsEquipmentSubType { get; set; }
    }
}
