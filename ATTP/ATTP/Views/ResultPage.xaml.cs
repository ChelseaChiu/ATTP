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
        public ObservableCollection<StudyPath> StudyPaths { get; }
        public ResultPage()
        {
            InitializeComponent();

            StudyPaths = new ObservableCollection<StudyPath>()
            {
                new StudyPath { StudyPathName="Diploma of Software Development", CourseCode="ICT50718" },
                new StudyPath { StudyPathName="Certificate IV of Programming",CourseCode="ICT40518"}
            };
            BindingContext = this;
            StudyPicker.SelectedIndexChanged += StudyPicker_SelectedIndexChanged;
        }

        public void StudyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var studyPath = StudyPaths[StudyPicker.SelectedIndex];

            //CompleteCourses = new ObservableCollection<Course>();
            //CompleteCourses.Add(new Course
            //{
            //    SubjectCode = "QQQQ",

            //    NationalCode = "EEEE",

            //    Grade = "pass"
            //});
            //CompleteCourseList.ItemsSource = CompleteCourses;
            //BindingContext = this;
            switch (studyPath.CourseCode)
            {
                case "ICT50718":
                    {

                        CompleteCourses = new ObservableCollection<Course>();
                        InProgressCourses = new ObservableCollection<Course>();

                        //Add Completed courses here
                        CompleteCourses.Add(new Course
                        {
                            SubjectCode = "QQQQ",

                            NationalCode = "EEEE",

                            Grade = "pass"
                        });
                        CompleteCourses.Add(new Course
                        {
                            SubjectCode = "AAAA",
                            NationalCode = "CCCC",
                            Grade = "Fail"
                        });
                        CompleteCourses.Add(new Course
                        {
                            SubjectCode = "NNNNN",
                            NationalCode = "CCFGCC",
                            Grade = "Fail"
                        });
                        //Add in progress courses here
                        InProgressCourses.Add(new Course
                        {
                            SubjectCode = "QQQQ",
                            TafeCode = "SssSS",
                            NationalCode = "EEEE",
                            CompetencyName = "asdas",
                            Grade = "pass"
                        });

                        //Add to be done courses here

                        CompleteCourseList.ItemsSource = CompleteCourses;
                        BindingContext = this;

                        break;
                    }
                case "ICT40518":
                    {
                        CompleteCourses = new ObservableCollection<Course>();
                        InProgressCourses = new ObservableCollection<Course>();

                        //Add Completed courses here
                        CompleteCourses.Add(new Course
                        {
                            SubjectCode = "QQQQ",
                            TafeCode = "SssSS",
                            NationalCode = "EEEE",
                            CompetencyName = "asdas",
                            Grade = "pass"
                        });
                        CompleteCourses.Add(new Course
                        {
                            SubjectCode = "AAAA",
                            NationalCode = "CCCC",
                            Grade = "Fail"
                        });

                        //Add in progress courses here
                        InProgressCourses.Add(new Course
                        {
                            SubjectCode = "BBBB",
                            NationalCode = "ADFF",
                            Grade = "N/A"
                        });

                        //Add to be done courses here

                        CompleteCourseList.ItemsSource = CompleteCourses;

                        BindingContext = this;

                        break;
                    }
            }
        }
    }
}