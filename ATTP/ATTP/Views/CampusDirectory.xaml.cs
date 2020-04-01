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
    public partial class CampusDirectory : ContentPage
    {
        public string imgURL;
        //set up collections for picker herehere
        public List<String> FloorList = new List<string>() { "Currie St Basement" };
        public String floor1 = "Currie St First Floor";
        

        public CampusDirectory()
        {
            InitializeComponent();
            //initial image change test
            imgURL = "Assets/CampusImages/SouthAustralia/CurrieStBasementFloor.png";
            //set up initial picker content (Comment this out when models implemented)
            FloorList.Add(floor1);
            //FloorList.Add("Currie St First Floor");

            imagePicker.ItemsSource = FloorList;

        }

        private void imagePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to handle specific image picked. Old way.
            var selection = imagePicker.SelectedIndex;
            string newImg = imgURL; //default image change
            switch (selection)
            {
                case 0:
                   {
                        newImg = "Assets/CampusImages/SouthAustralia/CurrieStBasementFloor.png";
                        break;
                    }
                case 1:
                    {
                        newImg = "Assets/CampusImages/SouthAustralia/CurrieStFirstFloor.png";
                        break;
                    }
                    //TODO more floors
                    //todo handle more campuses
                default:
                    {
                        newImg = "Assets/CampusImages/SouthAustralia/AllCampuses.png";
                        break;
                    }
            }
            


            floorImg.Source = newImg;
           // floorImg.App
        }

        //public ObservableCollection<CrnSessionTimetable> Classes { get; set; }


        /*TODO: set up class for locations
         *TODO: set up initial picker to show a small group of images for testing
         *TODO: set up image to show default map
         *TODO: set up picker selection changed method to show image based on selection
         *TODO once working, update picker to handle all AU tafe maps. (Can use 2 pickers).
         * 
         */
    }
}