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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("IMPORTANT", "Have you done your orientation?", "YES", "NO");
            if (answer == true)
            {
                
            }
        }
    }
}