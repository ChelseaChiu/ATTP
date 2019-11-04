using ATTP.Data;
using ATTP.Resources;
using Plugin.Multilingual;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATTP.Models;
using ATTP.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ATTP.Resources;

using Plugin.Multilingual;
using System.Globalization;
using System.Windows.Input;
using ProgressRingControl.Forms.Plugin;
using SkiaSharp;


namespace ATTP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {

        public HomePage()
        {
            InitializeComponent();
            var progressRing = new ProgressRing { RingThickness = 5, Progress = 0.34f, RingBaseColor = Color.Gray, RingProgressColor = Color.Blue, Scale = 10 };

            ParchmentButton.Text = AppResources.TranslationApplyforParchment; 





        }

        //void switchToggledAsync(object sender , System.ComponentModel.PropertyChangedEventArgs e)
        //{
        //    initateProgressUpdate();
        //}




        protected async override void OnAppearing()
        {
            var result = true;

            if (App._UwUnotification == true)
            { 
            switch (App._language)
            {
                case "zh-Hans":
                    {
                         result = await Application.Current.MainPage.DisplayAlert("重要", "你做完定向了吗？", "是", "没有");

                            if (result == true)
                            {
                                App._UwUnotification = false;
                                App._desuNot = false;

                            }

                            else
                            {
                                App._UwUnotification = true;

                            }


                            base.OnAppearing();

                            break;
                    }
                case "zh-Hant":
                    {
                            result = await Application.Current.MainPage.DisplayAlert("IMPORTANT", "Have you done your orientation?", "YES", "NO");

                            if (result == true)
                            {
                                App._UwUnotification = false;
                                App._desuNot = false;

                            }

                            else
                            {
                                App._UwUnotification = true;
                                App._desuNot = false;

                            }

                            base.OnAppearing();

                        break;
                    }
                case "en":
                    {
                            result = await Application.Current.MainPage.DisplayAlert("IMPORTANT", "Have you done your orientation?", "YES", "NO");

                            if (result == true)
                            {
                                App._UwUnotification = false;
                                App._desuNot = false;

                            }

                            else
                            {
                                App._UwUnotification = true;

                            }

                            base.OnAppearing();

                            break;

                    }
                case "mn-MN":
                    {
                            result = await Application.Current.MainPage.DisplayAlert("IMPORTANT", "Have you done your orientation?", "YES", "NO");

                            if (result == true)
                            {
                                App._UwUnotification = false;
                                App._desuNot = false;

                            }

                            else
                            {
                                App._UwUnotification = true;

                            }

                            base.OnAppearing();

                            break;


                    }
                case "ms":
                    {
                            result = await Application.Current.MainPage.DisplayAlert("IMPORTANT", "Have you done your orientation?", "YES", "NO");


                            if (result == true)
                            {
                                App._UwUnotification = false;
                                App._desuNot = false;

                            }

                            else
                            {
                                App._UwUnotification = true;

                            }

                            base.OnAppearing();

                            break;
                        }
                case "fr":
                    {
                            result = await Application.Current.MainPage.DisplayAlert("IMPORTANT", "Have you done your orientation?", "YES", "NO");

                            if (result == true)
                            {
                                App._UwUnotification = false;
                                App._desuNot = false;

                            }

                            else
                            {
                                App._UwUnotification = true;

                            }

                            base.OnAppearing();

                            break;
                        }
                case "de":
                    {
                            result = await Application.Current.MainPage.DisplayAlert("IMPORTANT", "Have you done your orientation?", "YES", "NO");


                            if (result == true)
                            {
                                App._UwUnotification = false;
                                App._desuNot = false;

                            }

                            else
                            {
                                App._UwUnotification = true;

                            }

                            base.OnAppearing();

                            break;
                        }
                case "ja":
                    {
                            result = await Application.Current.MainPage.DisplayAlert("IMPORTANT", "Have you done your orientation?", "YES", "NO");


                            if (result == true)
                            {
                                App._UwUnotification = false;
                                App._desuNot = false;

                            }

                            else
                            {
                                App._UwUnotification = true;

                            }

                            base.OnAppearing();

                            break;
                        }
                case "ko":
                    {
                            result = await Application.Current.MainPage.DisplayAlert("중요", "오리엔테이션을 완료했습니까 ? ", "예", "아니오");


                            if (result == true)
                            {
                                App._UwUnotification = false;
                                //App._desuNot = false;

                            }

                            else
                            {
                                App._UwUnotification = true;

                            }

                            base.OnAppearing();

                            break;
                        }
                case "ru":
                    {
                            result = await Application.Current.MainPage.DisplayAlert("IMPORTANT", "Have you done your orientation?", "YES", "NO");


                            if (result == true)
                            {
                                App._UwUnotification = false;
                                App._desuNot = false;

                            }

                            else
                            {
                                App._UwUnotification = true;

                            }

                            base.OnAppearing();

                            break;
                        }
            }
            }


        }

        protected void ParchmentBtnClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.tafesa.edu.au/services/parchments-results/request-parchment"));
        }
    }
}