﻿using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsOwnerType
    {
        public MsOwnerType()
        {
            MsOwner = new HashSet<MsOwner>();
        }

        public Guid OwnerTypeIndex { get; set; }
        public string OwnerTypeId { get; set; }
        public string OwnerTypeName { get; set; }
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

        public virtual ICollection<MsOwner> MsOwner { get; set; }
    }
}
