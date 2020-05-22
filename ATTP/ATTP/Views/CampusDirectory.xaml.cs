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

        public List<String> CampusList = new List<string>() { "Currie St", "Regency" };

        //Picker using Model setup
        public ObservableCollection<Floor> Floors { get; set; }

        public ObservableCollection<Floor> RegencyFloors { get; set; }
        public ObservableCollection<Floor> CurrieFloors { get; set; }
        public CampusDirectory()
        {
            InitializeComponent();
            //initial image change test from default image
            imgURL = "CurrieStBasementFloor.png";
            //set up initial picker content (Comment this out when models implemented)
            FloorList.Add(floor1);

            //using model. These are the default floors (Adelaide campus)
            Floors = new ObservableCollection<Floor> { new Floor { FloorName = "Basement", FloorImgUrl = "CurrieStBasementFloor.png" } };

            Floors.Add(new Floor { FloorName = "Ground Floor", FloorImgUrl = "CurrieStGroundFloor.png" });
            Floors.Add(new Floor { FloorName = "First Floor", FloorImgUrl = "CurrieStFirstFloor.png" });
            Floors.Add(new Floor { FloorName = "Second Floor", FloorImgUrl = "CurrieStSecondFloor.png" });
            Floors.Add(new Floor { FloorName = "Third Floor", FloorImgUrl = "CurrieStThirdFloor.png" });
            Floors.Add(new Floor { FloorName = "Fourth Floor", FloorImgUrl = "CurrieStFourthFloor.png" });

            RegencyFloors = new ObservableCollection<Floor> { new Floor { FloorName = "Ground Floor", FloorImgUrl = "RegencyGroundFloor.png" } };
            RegencyFloors.Add(new Floor { FloorName = "First Floor", FloorImgUrl = "RegencyFirstFloor.png" });
            CurrieFloors = Floors; //currie list is the default floors list.

            //the picker that chooses the floor. TODO: have default floors be Currie St.
            //imagePicker.ItemsSource = FloorList; //old method

            imagePicker.ItemsSource = Floors;

            campusPicker.ItemsSource = CampusList;
            campusPicker.SelectedItem = CampusList[0];

            BindingContext = this;


        }




        //picks the floor
        private void imagePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to handle specific image picked. Old way using hardcoded strings.
            //var selection = imagePicker.SelectedIndex;

            var floorSelection = imagePicker.SelectedItem as Floor;

            string newImg = imgURL; //default image change
            if (floorSelection != null)
            {
                newImg = floorSelection.FloorImgUrl;
                floorImg.Source = newImg;
            }

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



            // floorImg.App
        }

        private void campusPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var campusSelection = campusPicker.SelectedItem as string;
            //may as well leave this hard coded
            switch (campusSelection)
            {
                case "Currie St":
                    {
                        imagePicker.ItemsSource = CurrieFloors;
                        //imagePicker.SelectedItem = CurrieFloors.FirstOrDefault<Floor>;
                        imagePicker.SelectedItem = CurrieFloors[0];
                        //default floor image here
                        //
                        break;
                    }
                case "Regency":
                    {
                        imagePicker.ItemsSource = RegencyFloors;
                        //default floor image here
                        imagePicker.SelectedItem = RegencyFloors[0];
                        break;
                    }
                default:
                    {
                        imagePicker.ItemsSource = Floors; //default floors are adelaide campus
                        break;
                    }
            }


        }

        //public ObservableCollection<CrnSessionTimetable> Classes { get; set; }


        /*
         *TODO: 
         *TODO: set up picker selection changed method to show image based on selection DONE
         *TODO once working, update picker to handle all AU tafe maps. (Can use 2 pickers).
         * 
         */
    }
}