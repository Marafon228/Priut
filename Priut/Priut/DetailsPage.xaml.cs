using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Priut
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        private Dog currentDog;

        public Dog CurrentDog
        {
            get { return currentDog; }
            set { currentDog = value; }
        }


        public DetailsPage(Dog dog)
        {
        
            InitializeComponent();
            CurrentDog = dog;

            BindingContext = this;


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Номер", CurrentDog.Phone , "OK");
        }
    }
}