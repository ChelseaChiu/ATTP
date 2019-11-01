using ATTP.Models;
using ATTP.Resources;
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
    public partial class ProfilePage : ContentPage
    {
        //public ObservableCollection<Address> personalinfo { get; set; }
        //public string streetname { get; set; }
        //public string streetname2 { get; set; }
        //public string city { get; set; }
        //public string state { get; set; }
        //public string postcode { get; set; }
        //public string phone { get; set; }
        //public string email { get; set; }



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



            //personalinfo = new ObservableCollection<Address>();
            //personalinfo.Add(new Address
            //{
            //streetname = "86A Gage Street Firle",
            //    streetname2 = "",
            //    city = "Adelaide",
            //    state = "SA",
            //    postcode = "5000",
            //    phone = "0428172166 ",
            //    email = "",

            //streetname = "86A Gage Street Firle";
            // streetname2 = "9";
            // city = "Adelaide";
            // state = "SA";
            // postcode = "5000";
            // phone = "0428172166 ";
            // email = " Martin Perez";



            //});


        }

        protected void EditBtnClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.tafesa.edu.au/mytafe-sa"));
        }
    }
}