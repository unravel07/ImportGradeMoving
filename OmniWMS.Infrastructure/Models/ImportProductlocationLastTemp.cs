using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ImportProductlocationLastTemp
    {
        public string ProductId { get; set; }
        public string ProductNameThai { get; set; }
        public string ProductNameEng { get; set; }
        public string Location { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
