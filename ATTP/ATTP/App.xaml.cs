using ATTP.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

namespace ATTP
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {

        static TokenDatabaseController tokenDatabase;
        static RestService restService;




    public App()
        {
            InitializeComponent();


            var culture = CrossMultilingual.Current.DeviceCultureInfo;
            AppResources.Culture = culture;


            MainPage = new ATTP.Views.LoginPage();
            //MainPage = new ATTP.Views.HomePage();
            //string id = user.Id;
            //string userName = Proxy.getStudentBuId(id).Username;



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

        public static string _language { get; set; }

        public static string _Username { get; set; }

        public static string _Id { get; set; }




        // ---- End 

    }
}
