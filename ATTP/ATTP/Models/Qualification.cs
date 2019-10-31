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

        public int DoneC { get; set; }
        public int DoneE { get; set; }
        public int DoneLE { get; set; }
        public int DoneTotal { get; set; }

        public Competency Competency { get; set; }

        public double Progress { get; set; }

        private string stringProgress;
        public string StringProgress
        {
            get { return stringProgress; }
            set { stringProgress= String.Format(Progress*100+" %"); }
        }

        private string stringCoreResult;
        public string StringCoreResult
        {
            get { return stringCoreResult; }
            set { stringCoreResult = String.Format("Core Units: {0} of {1}",DoneC,CoreUnits); }
        }

        private string stringElectiveResult;
        public string StringElectiveResult
        {
            get { return stringElectiveResult; }
            set { stringElectiveResult = String.Format("Elective Units: {0} of {1}",DoneE,ElectedUnits); }
        }

        private string stringLEResult;
        public string StringLEResult
        {
            get { return stringLEResult; }
            set { stringLEResult = String.Format("ReqListedElectedUnits Elective Units: {0} of {1}", DoneLE, ElectedUnits); }
        }

        private string stringTotalResult;
        public string StringTotalResult
        {
            get { return stringTotalResult; }
            set { stringTotalResult = String.Format("Total Units: {0} of {1}",DoneTotal,TotalUnits); }
        }
    }
}
