using ATTP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ATTP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        public ObservableCollection<Course> CompleteCourses { get; set; }
        public ObservableCollection<Course> InProgressCourses { get; set; }
        public ObservableCollection<Course> ToBeDoneCourses { get; set; }
        public ObservableCollection<Qualification> StudyPaths { get; }
        public ResultPage()
        {
            InitializeComponent();

            List<Qualification> qualifications = Proxy.GetQualifications(App._Id);
            StudyPicker.ItemsSource = qualifications;

            StudyPicker.SelectedIndexChanged += StudyPicker_SelectedIndexChanged;









            //StudyPaths = new ObservableCollection<Qualification>()
            //{
            //    new Qualification { QualName="Diploma of Software Development", TafeQualCode="ICT50715" },
            //    new Qualification { QualName="Certificate IV of Programming",TafeQualCode="ICT40515"}

            //};
            //BindingContext = this;
            //StudyPicker.SelectedIndexChanged += StudyPicker_SelectedIndexChanged;
        }

        public void StudyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var studyPath = StudyPaths[StudyPicker.SelectedIndex];

            try
            {
                App._QualId = studyPath.TafeQualCode;
            }

            catch (Exception)
            {

            }

                CompleteCourses = new ObservableCollection<Course>();
                InProgressCourses = new ObservableCollection<Course>();
                ToBeDoneCourses = new ObservableCollection<Course>();

            //List<Competency> passedComp = Proxy.GetCompetencies(App._Id, App._QualId);

            //StudentServiceRef.Competency competency = Proxy.GetCompetenciesPassed(App._Id, App._QualId);

            //List<Qualification> qualifications = Proxy.GetQualifications(App._Id);






        }

    }
}



//        public void StudyPicker_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            var studyPath = StudyPaths[StudyPicker.SelectedIndex];

//            switch (studyPath.TafeQualCode)
//            {
//                case "ICT50715":
//                    {

//                        CompleteCourses = new ObservableCollection<Course>();
//                        InProgressCourses = new ObservableCollection<Course>();
//                        ToBeDoneCourses = new ObservableCollection<Course>();

//                        //Add Completed courses here
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "3PRB",
//                            TafeCode = "TAAGC",
//                            NationalCode = "ICTPRG301",
//                            Semester = "2",
//                            Year="2018",
//                            Grade = "PA"
//                        }) ;
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4C#B",
//                            TafeCode = "TAADC",
//                            NationalCode = "ICTPRG414",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4CEP",
//                            TafeCode = "TAABL",
//                            NationalCode = "ICTICT418",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4DBB",
//                            TafeCode = "TAAHA",
//                            NationalCode = "ICTWEB425",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4HTML5",
//                            TafeCode = "TAAGN",
//                            NationalCode = "ICTWEB301",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4JSB",
//                            TafeCode = "TAACZ",
//                            NationalCode = "ICTPRG405",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4JAB",
//                            TafeCode = "TAADA",
//                            NationalCode = "ICTPRG406",
//                            Semester = "1",
//                            Year = "2019",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4C#M",
//                            TafeCode = "TAADE",
//                            NationalCode = "ICTPRG418",
//                            Semester = "1",
//                            Year = "2019",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4SDB",
//                            TafeCode = "TAADF",
//                            NationalCode = "ICTPRG419",
//                            Semester = "1",
//                            Year = "2019",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "5TST",
//                            TafeCode = "TAADK",
//                            NationalCode = "ICTPRG503",
//                            Semester = "1",
//                            Year = "2019",
//                            Grade = "P"
//                        });

//                        //Add in progress courses here
//                        InProgressCourses.Add(new Course
//                        {
//                            SubjectCode = "5C#W",
//                            TafeCode = "TAADN",
//                            NationalCode = "ICTPRG523",
//                            Semester = "2",
//                            Year = "2019",
//                            Grade = "N/A"
//                        });
//                        InProgressCourses.Add(new Course
//                        {
//                            SubjectCode = "5DD",
//                            TafeCode = "TAAHC",
//                            NationalCode = "ICTDBS502",
//                            Semester = "2",
//                            Year = "2019",
//                            Grade = "N/A"
//                        });
//                        InProgressCourses.Add(new Course
//                        {
//                            SubjectCode = "5JAM",
//                            TafeCode = "TAADP",
//                            NationalCode = "ICTPRG527",
//                            Semester = "2",
//                            Year = "2019",
//                            Grade = "N/A"
//                        });
//                        InProgressCourses.Add(new Course
//                        {
//                            SubjectCode = "5MITP",
//                            TafeCode = "TAACR",
//                            NationalCode = "ICTPMG501",
//                            Semester = "2",
//                            Year = "2019",
//                            Grade = "N/A"
//                        });
//                        InProgressCourses.Add(new Course
//                        {
//                            SubjectCode = "5TSD",
//                            TafeCode = "TAADH",
//                            NationalCode = "ICTPRG502",
//                            Semester = "2",
//                            Year = "2019",
//                            Grade = "N/A"
//                        });
//                        InProgressCourses.Add(new Course
//                        {
//                            SubjectCode = "5WORK1",
//                            TafeCode = "TAADM",
//                            NationalCode = "ICTPRG520",
//                            Semester = "2",
//                            Year = "2019",
//                            Grade = "N/A"
//                        });
//                        InProgressCourses.Add(new Course
//                        {
//                            SubjectCode = "5WORK1",
//                            TafeCode = "TAADR",
//                            NationalCode = "ICTPRG529",
//                            Semester = "2",
//                            Year = "2019",
//                            Grade = "N/A"
//                        });

//                        //Add to be done courses here
//                        ToBeDoneCourses.Add(new Course
//                        {
//                            SubjectCode = "5TSD",
//                            TafeCode = "TAADL",
//                            NationalCode = "ICTPRG504",
//                            Semester = "N/A",
//                            Year = "N/A",
//                            Grade = "N/A"
//                        });
//                        ToBeDoneCourses.Add(new Course
//                        {
//                            SubjectCode = "5IOSMD",
//                            TafeCode = "TAAHY",
//                            NationalCode = "ICTPRG505",
//                            Semester = "N/A",
//                            Year = "N/A",
//                            Grade = "N/A"
//                        });
//                        ToBeDoneCourses.Add(new Course
//                        {
//                            SubjectCode = "5JAW",
//                            TafeCode = "TAADG",
//                            NationalCode = "ICTPRG501",
//                            Semester = "N/A",
//                            Year = "N/A",
//                            Grade = "N/A"
//                        });
//                        ToBeDoneCourses.Add(new Course
//                        {
//                            SubjectCode = "5SDA",
//                            TafeCode = "TAAKL",
//                            NationalCode = "ICTSAD505",
//                            Semester = "N/A",
//                            Year = "N/A",
//                            Grade = "N/A"
//                        });
//                        ToBeDoneCourses.Add(new Course
//                        {
//                            SubjectCode = "5SDA",
//                            TafeCode = "TAAHZ",
//                            NationalCode = "ICTPRG506",
//                            Semester = "N/A",
//                            Year = "N/A",
//                            Grade = "N/A"
//                        });
//                        ToBeDoneCourses.Add(new Course
//                        {
//                            SubjectCode = "6CLP",
//                            TafeCode = "TAAKA",
//                            NationalCode = "ICTPRG604",
//                            Semester = "N/A",
//                            Year = "N/A",
//                            Grade = "N/A"
//                        });


//                        CompleteCourseList.ItemsSource = CompleteCourses;
//                        InProgressCourseList.ItemsSource = InProgressCourses;
//                        ToBeDoneCourseList.ItemsSource = ToBeDoneCourses;
//                        BindingContext = this;

//                        break;
//                    }
//                case "ICT40515":
//                    {
//                        CompleteCourses = new ObservableCollection<Course>();
//                        InProgressCourses = new ObservableCollection<Course>();
//                        ToBeDoneCourses = new ObservableCollection<Course>();

//                        //Add Completed courses here
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "3WHS",
//                            TafeCode = "TAAGC",
//                            NationalCode = "BSBWHS304",
//                            Semester = "1",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4CEP",
//                            TafeCode = "TAABL",
//                            NationalCode = "ICTICT418",
//                            Semester = "1",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4JSB",
//                            TafeCode = "TAACZ",
//                            NationalCode = "ICTPRG405",
//                            Semester = "1",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4BUI",
//                            TafeCode = "TAAGF",
//                            NationalCode = "ICTPRG410",
//                            Semester = "1",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4C#B",
//                            TafeCode = "TAADC",
//                            NationalCode = "ICTPRG414",
//                            Semester = "1",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4DBB",
//                            TafeCode = "TAAHA",
//                            NationalCode = "ICTWEB425",
//                            Semester = "1",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4JAB",
//                            TafeCode = "TAADA",
//                            NationalCode = "ICTPRG406",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4SDB",
//                            TafeCode = "TAADF",
//                            NationalCode = "ICTPRG419",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4SDB",
//                            TafeCode = "TAADF",
//                            NationalCode = "ICTPRG415",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4C#M",
//                            TafeCode = "TAADE",
//                            NationalCode = "ICTPRG418",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "5EWD",
//                            TafeCode = "TAAHC",
//                            NationalCode = "ICTWEB502",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "5EWD",
//                            TafeCode = "TAAHC",
//                            NationalCode = "ICTDBS504",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4SPRJ",
//                            TafeCode = "TAASA",
//                            NationalCode = "ICAICT408",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4SPRJ",
//                            TafeCode = "TAASA",
//                            NationalCode = "ICTDBS403",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4SPRJ",
//                            TafeCode = "TAASA",
//                            NationalCode = "ICTICT403",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        CompleteCourses.Add(new Course
//                        {
//                            SubjectCode = "4SPRJ",
//                            TafeCode = "TAASA",
//                            NationalCode = "ICTPRG413",
//                            Semester = "2",
//                            Year = "2018",
//                            Grade = "PA"
//                        });
//                        //Add in progress courses here
//                        InProgressCourses.Add(new Course
//                        {
//                            SubjectCode = "N/A",
//                            TafeCode = "N/A",
//                            NationalCode = "N/A",
//                            Semester = "N/A",
//                            Year = "N/A",
//                            Grade = "N/A"
//                        });

//                        //Add to be done courses here
//                        ToBeDoneCourses.Add(new Course
//                        {
//                            SubjectCode = "N/A",
//                            TafeCode = "N/A",
//                            NationalCode = "N/A",
//                            Semester = "N/A",
//                            Year = "N/A",
//                            Grade = "N/A"
//                        });

//                        CompleteCourseList.ItemsSource = CompleteCourses;
//                        InProgressCourseList.ItemsSource = InProgressCourses;
//                        ToBeDoneCourseList.ItemsSource = ToBeDoneCourses;

//                        BindingContext = this;

//                        break;
//                    }
//            }
//        }
//    }
//}