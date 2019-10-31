using System;
using System.Collections.Generic;
using System.Text;

namespace ATTP.Models
{
    public class Competency
    {
        public string TafeCompCode { get; set; }
        public string NationaCompCode { get; set; }

        public int Hours { get; set; }
        public string CompTypeCode { get; set; }

        public string SubjectCode { get; set; }
        public string Results { get; set; }

        public string CompetencyName{get;set;}


    }
}
