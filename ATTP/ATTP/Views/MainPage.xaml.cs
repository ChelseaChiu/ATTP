using ATTP.Models;
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
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            menuList = new List<MasterPageItem>();
            // Adding menu items to menuList and you can define title ,page and icon
            menuList.Add(new MasterPageItem() { Title = "Home", IconSource = "Home.png", TargetType = typeof(HomePage) });
            menuList.Add(new MasterPageItem() { Title = "Result", IconSource = "Result.png", TargetType = typeof(ResultPage) });
            menuList.Add(new MasterPageItem() { Title = "Transcript", IconSource = "Transcript.png", TargetType = typeof(TransciptPage) });
            menuList.Add(new MasterPageItem() { Title = "Profile", IconSource = "Profile.png", TargetType = typeof(ProfilePage) });
            menuList.Add(new MasterPageItem() { Title = "Log Out", IconSource = "Exit.png", TargetType = typeof(LoginPage) });
            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }
        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}