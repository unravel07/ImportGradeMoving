using System;
using System.Collections.Generic;

namespace OmniWMS.Infrastructure.Models
{
    public partial class ViewTruckLoadCarton
    {
        public long? RowIndex { get; set; }
        public Guid TruckLoadIndex { get; set; }
        public string TruckLoadNo { get; set; }
        public Guid? TagOutPickIndex { get; set; }
        public string TagOutPickNo { get; set; }
        public Guid RefDocumentIndex { get; set; }
        public string RefDocumentNo { get; set; }
        public Guid? TagOutIndex { get; set; }
        public string TagOutNo { get; set; }
        public string DueDate { get; set; }
        public Guid? RouteIndex { get; set; }
        public string RouteName { get; set; }
        public Guid? RoundIndex { get; set; }
        public string RoundName { get; set; }
        public bool IsLoadCarton { get; set; }
        public string LoadDate { get; set; }
        public string LoadTime { get; set; }
        public string LoadBy { get; set; }
    }
}
