using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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

        public string StringProgress { get; set; }

        public string StringCoreResult { get; set; }

        public string StringElectiveResult { get; set; }

        public string StringLEResult { get; set; }


        public string StringTotalResult { get; set; }



    }
    //public class QualficationResultView : INotifyPropertyChanged
    //{
    //    List<Qualification> studyPaths;
    //    public List<Qualification> StudyPaths
    //    {
    //        get { return studyPaths; }
    //        set
    //        {
    //            if (studyPaths != value)
    //            {
    //                studyPaths = value;
    //                OnPropertyChanged();
    //            }
    //        }
    //    }

    //    Qualification selectedJob;
    //    public Qualification SelectedJob
    //    {
    //        get { return selectedJob; }
    //        set
    //        {
    //            if (selectedJob != value)
    //            {
    //                selectedJob = value;
    //                OnPropertyChanged();
    //            }
    //        }
    //    }


    //    public event PropertyChangedEventHandler PropertyChanged;

    //    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //    {
    //        PropertyChangedEventHandler handler = PropertyChanged;
    //        if (handler != null)
    //        {
    //            handler(this, new PropertyChangedEventArgs(propertyName));
    //        }
    //    }
    //}
}
