using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class MsWave
    {
        public MsWave()
        {
            MsWaveRule = new HashSet<MsWaveRule>();
        }

        public Guid WaveIndex { get; set; }
        public string WaveId { get; set; }
        public string WaveName { get; set; }
        public string WaveCase { get; set; }
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

        public virtual ICollection<MsWaveRule> MsWaveRule { get; set; }
    }
}
