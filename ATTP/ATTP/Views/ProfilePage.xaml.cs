using ATTP.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ATTP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();

            StreetLbl.Text = AppResources.TranslationStreetLbl;
            //StreetLbl.Text = AppResources.TranslationStreet1Lbl;
            //StreetLbl.Text = AppResources.TranslationCityLbl;
            //StreetLbl.Text = AppResources.TranslationStateLbl;
            //StreetLbl.Text = AppResources.TranslationPostcodeLbl;
            //StreetLbl.Text = AppResources.TranslationPhoneLbl;
            //StreetLbl.Text = AppResources.TranslationEmailLbl;


        }

        protected void EditBtnClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.tafesa.edu.au/mytafe-sa"));
        }
    }
}