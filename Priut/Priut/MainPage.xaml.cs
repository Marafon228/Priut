using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Priut
{
    public partial class MainPage : ContentPage
    {
        public UserAuth CurrentUser { get; set; }
        public MainPage()
        {
            CurrentUser = new UserAuth();
            InitializeComponent();
            BindingContext = this;
        }

        private async void Btn_SignIn(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            var result = client.UploadString("http://192.168.0.100:3245/api/Users/SignIn", JsonConvert.SerializeObject(CurrentUser));
            if (result != null)
            {
                var roleUser = JsonConvert.DeserializeObject<User>(result);
                if (roleUser.Login != null)
                {
                    await DisplayAlert("Message", "Registration was successful", "OK");
                    await Navigation.PushAsync(new StartPage(), true);
                }
                else
                {
                    await DisplayAlert("Message", "Registration fail", "OK");

                }
            }
        }

        private async void Btn_Reg(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterUser(), true);
        }
    }
}
