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

        protected override void OnAppearing()
        {

            switch (App._language)
            {
                case "zh-Hans":
                    {
                        Application.Current.MainPage.DisplayAlert("重要", "请点击'选择时间表日期'以选择日期： ", "是");

                        base.OnAppearing();

                        break;
                    }
                case "zh-Hant":
                    {
                        Application.Current.MainPage.DisplayAlert("重要", "請點擊'選擇時間表日期'以選擇日期： ", "是");

                        base.OnAppearing();

                        break;
                    }
                case "en":
                    {
                        Application.Current.MainPage.DisplayAlert("IMPORTANT", "Please click on 'Select the timetable day' to select the day : ", "OK");

                        base.OnAppearing();

                        break;
                    }
                case "mn-MN":
                    {
                        Application.Current.MainPage.DisplayAlert("ЧУХАЛ", "Өдөр сонгохын тулд 'Цагийн хуваарийг сонгох' гэснийг товшино уу: ", "тийм");

                        base.OnAppearing();

                        break;
                    }
                case "ms":
                    {
                        Application.Current.MainPage.DisplayAlert("PENTING", "Sila klik pada 'Pilih jadual waktu' untuk memilih hari: ", "okey");

                        base.OnAppearing();

                        break;
                    }
                case "fr":
                    {
                        Application.Current.MainPage.DisplayAlert("IMPORTANT", "S'il vous plaît cliquer sur 'Sélectionnez le jour de l'horaire' pour sélectionner le jour: ", "Oui");

                        base.OnAppearing();

                        break;
                    }
                case "de":
                    {
                        Application.Current.MainPage.DisplayAlert("WICHTIG", "Bitte klicken Sie auf Stundenplan auswählen , um den Tag auszuwählen: ", "Ja");

                        base.OnAppearing();

                        break;
                    }
                case "ja":
                    {
                        Application.Current.MainPage.DisplayAlert("「重要」", "時刻表の日を選択」をクリックして日を選択してください：", "はい");

                        base.OnAppearing();

                        break;
                    }
                case "ko":
                    {
                        Application.Current.MainPage.DisplayAlert("중요", "요일을 선택하십시오. : ", "확인");

                        base.OnAppearing();

                        break;
                    }
                case "da":
                    {
                        Application.Current.MainPage.DisplayAlert("VIGTIG", "Klik på 'Vælg køreplandag' for at vælge dagen: ", "Okay");

                        base.OnAppearing();

                        break;
                    }
                case "id":
                    {
                        Application.Current.MainPage.DisplayAlert("PENTING", "Silakan klik 'Pilih hari jadwal' untuk memilih hari: ", "baik");

                        base.OnAppearing();

                        break;
                    }
                case "vi":
                    {
                        Application.Current.MainPage.DisplayAlert("QUAN TRỌNG", "Vui lòng nhấp vào 'Chọn ngày có thời gian biểu' để chọn ngày: ", "đồng ý");

                        base.OnAppearing();

                        break;
                    }
                case "sr-Cyrl":
                    {
                        Application.Current.MainPage.DisplayAlert("ВАЖНО", "Молимо кликните на„ Изаберите дан распореда “да бисте изабрали дан: ", "ОК");

                        base.OnAppearing();

                        break;
                    }
                case "ru":
                    {
                        Application.Current.MainPage.DisplayAlert("IMPORTANT", "Please click on 'Select the timetable day' to select the day : ", "OK");

                        base.OnAppearing();

                        break;
                    }


            }
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
                                SubjectCode = "3PRB",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Tervor Leary",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "B.002",
                                Instructor = "KT LAU",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA Prac",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "KT LAU",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5JAW",
                                Duration = "16:00 ~ 18:00",
                                Room = "A.A156",
                                Instructor = "Dale Van Heer ",
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
                                SubjectCode = "5JAW PRAC",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Dale Van Heer",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "PRAC",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Dale Van Heer",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "6MITP",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Western Smith",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5WHSM",
                                Duration = "16:00 ~ 18:00",
                                Room = "A.A156",
                                Instructor = "Keven Smith",
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
                                Instructor = "KT Lau",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });

                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5JAW",
                                Duration = "16:00 ~ 18:00",
                                Room = "A.A156",
                                Instructor = "Julie Ruiz",
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
                                SubjectCode = "5MWD",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Santi Lee",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });

                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5MWD Prac",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Santi Lee",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5IUOS",
                                Duration = "16:00 ~ 18:00",
                                Room = "A.A156",
                                Instructor = "Kai Nyugen",
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
                                SubjectCode = "5IUOS Prac",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Kai Nyugen",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5SDA",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "KT Lau",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00)

                            });
                            Classes.Add(new CrnSessionTimetable
                            {
                                SubjectCode = "5ICW",
                                Duration = "9:00 ~ 13:00",
                                Room = "A.A116",
                                Instructor = "Jessi Lee",
                                CampusCode = "Adelaide",
                                StartTime = TodayAt(9, 00),
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

