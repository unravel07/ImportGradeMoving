﻿using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class Provinces
    {
        public Provinces()
        {
            Districts = new HashSet<Districts>();
        }

        public int Id { get; set; }
        public int Code { get; set; }
        public string NameInThai { get; set; }
        public string NameInEnglish { get; set; }

        public virtual ICollection<Districts> Districts { get; set; }
    }
}
