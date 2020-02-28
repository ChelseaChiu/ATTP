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
using System.ComponentModel;

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

            List<Qualification> qualifications = Proxy.GetQualifications(App._Id);

            foreach (Qualification q in qualifications)
            {
                q.StringCoreResult = String.Format("Core Units: {0} of {1}", q.DoneC, q.CoreUnits);
                q.StringElectiveResult = String.Format("Elective Units: {0} of {1}", q.DoneE, q.ElectedUnits);
                q.StringLEResult = String.Format("List Elective Units: {0} of {1}", q.DoneLE, q.ReqListedElectedUnits);
                q.StringTotalResult = String.Format("Total Units: {0} of {1}", q.DoneTotal, q.TotalUnits);
                q.Progress = Proxy.CalQualProgress(App._Id, q.QualCode);
                q.StringProgress = String.Format(q.Progress * 100 + "%");
            }

            qualListView.ItemsSource = qualifications;
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