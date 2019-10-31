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
    public partial class TimetablePage : ContentPage
    {

        private static DateTime TodayAt(int hour, int minute)
        {
            return new DateTime(DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                hour, minute, 0);
        }

        public ObservableCollection<CRNCourseDay> CRNCourseDays { get; }

        public ObservableCollection<CrnSessionTimetable> Classes { get; set; }

        public TimetablePage()
        {
            //BindingContext = Dummydata.Classes;
            InitializeComponent();
            CRNDAYPicker.SelectedIndex = 1;
            CRNCourseDays = new ObservableCollection<CRNCourseDay>
            {
                new CRNCourseDay{ CRNCourseDayName ="Monday", CRNCourseDayNumber="1" },
                new CRNCourseDay{ CRNCourseDayName ="Tuesday", CRNCourseDayNumber="2" },
                new CRNCourseDay{ CRNCourseDayName ="Wensday", CRNCourseDayNumber="3" },
                new CRNCourseDay{ CRNCourseDayName ="Thursday", CRNCourseDayNumber="4" },
                new CRNCourseDay{ CRNCourseDayName ="Friday", CRNCourseDayNumber="5" }


            };


            BindingContext = this;
            CRNDAYPicker.SelectedIndexChanged += CRNDAYPicker_SelectedIndexChanged;
        }

        public void CRNDAYPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var courseDay = CRNCourseDays[CRNDAYPicker.SelectedIndex];

            switch (courseDay.CRNCourseDayName)
            {
                case "Monday":
                    {

                        Classes = new ObservableCollection<CrnSessionTimetable>();
                        {

                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "UWU",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5JAW",
                                Duration = "16:00 ~ 18:00",
                                Room = "A.A156",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(16, 00),
                                IsLast = true,
                            });
                        };
                        TimetableListView.ItemsSource = Classes;
                        BindingContext = this;
                        break;


                    }
                case "Tuesday":
                    {

                        Classes = new ObservableCollection<CrnSessionTimetable>();
                        {

                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5JAW",
                                Duration = "16:00 ~ 18:00",
                                Room = "A.A156",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(16, 00),
                                IsLast = true,
                            });
                        };
                        TimetableListView.ItemsSource = Classes;
                        BindingContext = this;

                        break;


                    }

                case "Wensday":
                    {

                        Classes = new ObservableCollection<CrnSessionTimetable>();
                        {

                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5JAW",
                                Duration = "16:00 ~ 18:00",
                                Room = "A.A156",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(16, 00),
                                IsLast = true,
                            });
                        };
                        TimetableListView.ItemsSource = Classes;
                        BindingContext = this;
                        break;


                    }

                case "Thursday":
                    {

                        Classes = new ObservableCollection<CrnSessionTimetable>();
                        {

                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5JAW",
                                Duration = "16:00 ~ 18:00",
                                Room = "A.A156",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(16, 00),
                                IsLast = true,
                            });
                        };

                        TimetableListView.ItemsSource = Classes;
                        BindingContext = this;
                        break;


                    }

                case "Friday":
                    {

                        Classes = new ObservableCollection<CrnSessionTimetable>();
                        {

                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5JAW",
                                Duration = "16:00 ~ 18:00",
                                Room = "A.A156",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(16, 00),
                                IsLast = true,
                            });
                        };
                        TimetableListView.ItemsSource = Classes;
                        BindingContext = this;
                        break;


                    }
            }

        }
    }
}

