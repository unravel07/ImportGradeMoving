using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace ImportGradeMoving
{
    public class ImportGradeMovingSetting
    {
        public string SaveAsFilePath { get; set; }
        public string DefaultGrade1 { get; set; }
        public string DefaultGrade2 { get; set; }
        public string Zone { get; set; }
        public List<string> ConfigGrades { get; set; }
        public string OrderTypeA { get; set; }
        public string OrderTypeSP { get; set; }
        public string ProcedureName { get; set; }
        public string UrlChangeGradeAPI { get; set; }

        public ImportGradeMovingSetting()
        {
            SaveAsFilePath = ConfigurationManager.AppSettings["SaveAsFilePath"];
            DefaultGrade1 = ConfigurationManager.AppSettings["DefaultGrade1"];
            DefaultGrade2 = ConfigurationManager.AppSettings["DefaultGrade2"];
            Zone = ConfigurationManager.AppSettings["Zone"];
            var strConfigGrade = ConfigurationManager.AppSettings["ConfigGrades"];
            ConfigGrades = strConfigGrade.Split(",").ToList();
            OrderTypeA = ConfigurationManager.AppSettings["OrderTypeA"];
            OrderTypeSP = ConfigurationManager.AppSettings["OrderTypeSP"];
            ProcedureName = ConfigurationManager.AppSettings["ProcedureName"];
            UrlChangeGradeAPI = ConfigurationManager.AppSettings["UrlChangeGradeAPI"];
        }
    }
}
