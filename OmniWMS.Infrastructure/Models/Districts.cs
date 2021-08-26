﻿using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class Districts
    {
        public Districts()
        {
            Subdistricts = new HashSet<Subdistricts>();
        }

        public int Id { get; set; }
        public int Code { get; set; }
        public string NameInThai { get; set; }
        public string NameInEnglish { get; set; }
        public int ProvinceId { get; set; }

        public virtual Provinces Province { get; set; }
        public virtual ICollection<Subdistricts> Subdistricts { get; set; }
    }
}
