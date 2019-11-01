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
    public partial class TransciptPage : ContentPage
    {
        public ObservableCollection<Course> CompletedCoursesA { get; set; }
        public ObservableCollection<Course> CompletedCoursesB { get; set; }

        public TransciptPage()
        {
            InitializeComponent();

            CompletedCoursesA = new ObservableCollection<Course>();
            CompletedCoursesB = new ObservableCollection<Course>();


            CompletedCoursesA.Add(new Course
            {
                SubjectCode = "3PRB",
                NationalCode = "ICTPRG301",
                CompetencyName = "Apply introductory programming techniques",
                Grade = "PA"
            });
            CompletedCoursesA.Add(new Course
            {
                SubjectCode = "4C#B",
                NationalCode = "ICTPRG414",
                CompetencyName = "Apply advanced object-oriented language skills",
                Grade = "PA"
            });
            CompletedCoursesA.Add(new Course
            {
                SubjectCode = "4CEP",
                NationalCode = "ICTICT418",
                CompetencyName = "Apply advanced programming skills in another language",
                Grade = "PA"
            });
            CompletedCoursesA.Add(new Course
            {
                SubjectCode = "4DBB",
                NationalCode = "ICTWEB425",
                CompetencyName = "Apply intermediate object-oriented language skills",
                Grade = "PA"
            });
            CompletedCoursesA.Add(new Course
            {
                SubjectCode = "4HTML5",
                NationalCode = "ICTWEB301",
                CompetencyName = "Apply testing techniques for software development	",
                Grade = "PA"
            });
            CompletedCoursesA.Add(new Course
            {
                SubjectCode = "4JSB",
                NationalCode = "ICTPRG405",
                CompetencyName = "Debug and monitor applications",
                Grade = "PA"
            });
            CompletedCoursesA.Add(new Course
            {
                SubjectCode = "3WHS",
                NationalCode = "BSBWHS304",
                CompetencyName = "Deploy an application to a production environment",
                Grade = "PA"
            });
            CompletedCoursesA.Add(new Course
            {
                SubjectCode = "4BUI",
                NationalCode = "ICTPRG410",
                CompetencyName = "Manage a project using software management tools",
                Grade = "PA"
            });
            CompletedCoursesA.Add(new Course
            {
                SubjectCode = "4SDB",
                NationalCode = "ICTPRG415",
                CompetencyName = "Validate an application design against specifications",
                Grade = "PA"
            });
            CompletedCoursesA.Add(new Course
            {
                SubjectCode = "4SDB",
                NationalCode = "ICTPRG419",
                CompetencyName = "Build advanced user interface",
                Grade = "PA"
            });
            CompletedCoursesA.Add(new Course
            {
                SubjectCode = "5EWD",
                NationalCode = "ICTWEB502",
                CompetencyName = "Create cloud computing services",
                Grade = "PA"
            });
            CompletedCoursesA.Add(new Course
            {
                SubjectCode = "5EWD",
                NationalCode = "ICTDBS504",
                CompetencyName = "Design a database",
                Grade = "PA"
            });

            CompletedCoursesB.Add(new Course
            {
                SubjectCode = "4JAB",
                NationalCode = "ICTPRG406",
                CompetencyName = "Design application architecture",
                Grade = "PA"
            });
            CompletedCoursesB.Add(new Course
            {
                SubjectCode = "4C#M",
                NationalCode = "ICTPRG418",
                CompetencyName = "Develop technical requirements for business solutions",
                Grade = "PA"
            });
            CompletedCoursesB.Add(new Course
            {
                SubjectCode = "4SDB",
                NationalCode = "ICTPRG419",
                CompetencyName = "Plan and direct complex ICT projects",
                Grade = "PA"
            });
            CompletedCoursesB.Add(new Course
            {
                SubjectCode = "5TST",
                NationalCode = "ICTPRG503",
                CompetencyName = "Prepare for software development using rapid application development",
                Grade = "PA"
            });

            CourseListA.ItemsSource = CompletedCoursesA;
            CourseListB.ItemsSource = CompletedCoursesB;
            BindingContext = this;
        }
    }
}