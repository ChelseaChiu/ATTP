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







        //async void OnAlertYesNoClicked(object sender, EventArgs e)
        //{
        //    await DisplayAlert("IMPORTANT", "Have you done your orientation?","OK");
        //}
        protected void ParchmentBtnClicked(object sender, EventArgs e) {
            Device.OpenUri(new Uri("https://www.tafesa.edu.au/services/parchments-results/request-parchment"));
        }
    }
}