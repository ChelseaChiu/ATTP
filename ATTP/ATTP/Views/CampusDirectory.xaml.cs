using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATTP.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ATTP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CampusDirectory : ContentPage
    {
        public string imgURL;
        
        //set up collections for picker here
        public List<String> FloorList = new List<string>() { "Currie St Basement" }; //TODO change this to use models.
        public String floor1 = "Currie St First Floor";

        //Model setup
        public ObservableCollection<Floor> Floors { get; set; }
        public CampusDirectory()
        {
            InitializeComponent();
            //initial image change test
            imgURL = "Assets/CampusImages/SouthAustralia/CurrieStBasementFloor.png";
            //set up initial picker content (Comment this out when models implemented)
            FloorList.Add(floor1);

            //using model
            Floors = new ObservableCollection<Floor> { new Floor { FloorName = "Basement", FloorImgUrl = "Assets/CampusImages/SouthAustralia/CurrieStBasementFloor.png" } };
            //Floors.Add(new Floor { );
            Floors.Add(new Floor { FloorName = "First Floor", FloorImgUrl = "Assets/CampusImages/SouthAustralia/CurrieStFirstFloor.png" });
            Floors.Add(new Floor { FloorName = "Second Floor", FloorImgUrl = "Assets/CampusImages/SouthAustralia/CurrieStSecondFloor.png" });
            Floors.Add(new Floor { FloorName = "Third Floor", FloorImgUrl = "Assets/CampusImages/SouthAustralia/CurrieStThirdFloor.png" });
            Floors.Add(new Floor { FloorName = "Fourth Floor", FloorImgUrl = "Assets/CampusImages/SouthAustralia/CurrieStFourthFloor.png" });


            //the picker that chooses the floor. TODO: have default floors be Currie St.
            //imagePicker.ItemsSource = FloorList;

            imagePicker.ItemsSource = Floors;

            BindingContext = this;


        }

        //picks the floor
        private void imagePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to handle specific image picked. Old way.
            var selection = imagePicker.SelectedIndex;
            var floorSelection = imagePicker.SelectedItem as Floor;

            string newImg = imgURL; //default image change

            newImg = floorSelection.FloorImgUrl;
            /*
             *
            //Hard coded method
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
            */


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