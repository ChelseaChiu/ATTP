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

namespace ATTP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public ObservableCollection<Language> Languages { get; }
        public LoginPage()
        {
            

            InitializeComponent();


            Languages = new ObservableCollection<Language>()
            {
                new Language { DisplayName =  "中文 - Chinese (simplified)", ShortName = "zh-Hans" },
                new Language { DisplayName =  "Chinese(Traditional)", ShortName = "zh-Hant" },
                new Language { DisplayName =  "English", ShortName = "en" },
                new Language { DisplayName =  "Mongolian", ShortName = "mn-MN" },
                new Language { DisplayName =  "Français - French", ShortName = "fr" },
                new Language { DisplayName =  "Deutsche - German", ShortName = "de" },
                new Language { DisplayName =  "日本語 - Japanese", ShortName = "ja" },
                new Language { DisplayName =  "한국어 - Korean", ShortName = "ko" },
                new Language { DisplayName =  "Română - Romanian", ShortName = "ro" },
                new Language { DisplayName =  "Русский - Russian", ShortName = "ru" }
            };

            BindingContext = this;
            PickerLanguages.SelectedIndexChanged += PickerLanguages_SelectedIndexChanged;

            Init();


        }
        public void PickerLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var language = Languages[PickerLanguages.SelectedIndex];

            try
            {
                var culture = new CultureInfo(language.ShortName);
                AppResources.Culture = culture;
                CrossMultilingual.Current.CurrentCultureInfo = culture;
            }
            catch (Exception)
            {
            }

            TranslationUsernameLabel.Text = AppResources.TranslationUsername;
            Entry_Username.Placeholder = AppResources.TranslationLogin;
            Entry_Password.Placeholder = AppResources.TranslationPassword;
            TranslationPasswordLabel.Text = AppResources.TranslationPassword;
            Btn_SignIn.Text = AppResources.TranslationSignIn;
            //IdislikeLivingTranslation.Text = AppResources.String1;


        }
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            TranslationUsernameLabel.TextColor = Constants.MainTextColor;
            TranslationPasswordLabel.TextColor = Constants.MainTextColor;
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
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Login", "Login Not COrrect, Error:empty username or password", "Okay");
            }


        }


    }
}
