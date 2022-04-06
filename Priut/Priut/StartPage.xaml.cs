using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Priut
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            var client = new WebClient();
            var response = client.DownloadString("http://192.168.0.100:3245/api/Dogs/GetDog");
            ListViewProducts.ItemsSource = JsonConvert.DeserializeObject<List<Dog>>(response);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Dog dog = ListViewProducts.SelectedItem as Dog;


            await Navigation.PushAsync(new DetailsPage(dog));

        }
    }
}