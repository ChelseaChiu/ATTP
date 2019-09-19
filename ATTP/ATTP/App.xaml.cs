using ATTP.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ATTP.Data;
using ATTP.Resources;
using Plugin.Multilingual;

namespace ATTP
{
    
    public partial class App : Application
    {

        static TokenDatabaseController tokenDatabase;
        static UserDatabaseController userDatabase;
        static RestService restService;

        public App()
        {
            InitializeComponent();

            var culture = CrossMultilingual.Current.DeviceCultureInfo;
            AppResources.Culture = culture;

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


        public static UserDatabaseController UserDatabase
        {
            get
            {
                if (userDatabase == null)
                {
                    userDatabase = new UserDatabaseController();
                }
                return userDatabase;

            }

        }


        public static TokenDatabaseController TokenDatabase
        {
            get
            {
                if (tokenDatabase == null)
                {
                    tokenDatabase = new TokenDatabaseController();
                }
                return tokenDatabase;

            }

        }

        public static RestService RestService
        {
            get
            {
                if (restService == null)
                {
                    restService = new RestService();

                }
                return restService;

            }
        }


        // ---- End 

    }
}
