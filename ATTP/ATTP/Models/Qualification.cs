using System;
using System.Collections.Generic;
using System.Text;

namespace ATTP.Models
{
    public class Qualification
    {
        public string QualCode { get; set; }
        public string TafeQualCode { get; set; }
        public string NationaQualCode { get; set; }
        public string QualName { get; set; }
        public int TotalUnits { get; set; }
        public int CoreUnits { get; set; }
        public int ElectedUnits { get; set; }
        public int ReqListedElectedUnits { get; set; }

        public Competency Competency { get; set; }
    }
}
