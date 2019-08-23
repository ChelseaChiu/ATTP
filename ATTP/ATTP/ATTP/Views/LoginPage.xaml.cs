using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATTP.Models;
using ATTP.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ATTP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Label_Username.TextColor = Constants.MainTextColor;
            Label_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginImageIcon.HeightRequest = Constants.LoginImageIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);

        }

        void SignInProcedure(object sender, EventArgs e)
        {

            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.Valdation())
            {
                DisplayAlert("Login", "Login Success", "Oke");
                 //App.UserDatabase.SaveUser(user);
            }
            else
            {
                DisplayAlert("Login", "Login Not COrrect, Error:empty username or password", "Okay");
            }


        }
    }
}
