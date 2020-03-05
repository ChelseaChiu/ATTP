using ATTP.Models;
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
    public partial class ResultPage : ContentPage
    {
        public ObservableCollection<Competency> CompleteCourses { get; set; }
        public ObservableCollection<Competency> InProgressCourses { get; set; }
        public ObservableCollection<Competency> ToBeDoneCourses { get; set; }
        public List<Qualification> qualifications { get; }
        public ResultPage()
        {
            InitializeComponent();

            qualifications = Proxy.GetQualifications(App._Id);
            StudyPicker.SelectedIndexChanged += StudyPicker_SelectedIndexChanged;
        }

        public void StudyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Qualification sQual = qualifications[StudyPicker.SelectedIndex];

            //TODO
            
        }
    }
}