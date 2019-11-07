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
                         result = await Application.Current.MainPage.DisplayAlert("重要", "你做完新生訓練了嗎？", "是", "没有");

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
                            result = await Application.Current.MainPage.DisplayAlert("重要", "你做完新生訓練了嗎？", "是", "沒有");

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
                            result = await Application.Current.MainPage.DisplayAlert("Чухал", "Та чиг баримжаа хийсэн үү?", "ТИЙМ", "Үгүй");

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
                            result = await Application.Current.MainPage.DisplayAlert("PENTING", "Adakah anda telah melakukan orientasi anda?", "YA", "TIDAK");


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
                            result = await Application.Current.MainPage.DisplayAlert("IMPORTANT", "Avez-vous fait votre orientation?", "OUI", "NON");

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
                            result = await Application.Current.MainPage.DisplayAlert("「重要」", "オリエンテーションをしましたか？", "はい", "いいえ");
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
                            result = await Application.Current.MainPage.DisplayAlert("WICHTIG", "Hast du dich orientiert?", "JA", "NEIN");
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
                    case "da":
                    {
                            result = await Application.Current.MainPage.DisplayAlert("VIGTIG", "Har du gjort din orientering ? ", "JA", "Ingen");


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
                    case "id":
                        {
                            result = await Application.Current.MainPage.DisplayAlert("PENTING", "Sudahkah Anda melakukan orientasi ? ", "IYA", "Tidak");
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
                    case "vi":
                        {
                            result = await Application.Current.MainPage.DisplayAlert("QUAN TRỌNG", "Bạn đã thực hiện định hướng của bạn ? ", "ĐÚNG", "Không");
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
                    case "sr-Cyrl":
                        {
                            result = await Application.Current.MainPage.DisplayAlert("ВАЖНО", "Јесте ли урадили своју оријентацију?", "ДА", "НЕ");
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