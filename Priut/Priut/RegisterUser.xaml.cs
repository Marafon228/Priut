﻿using Newtonsoft.Json;
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
    public partial class RegisterUser : ContentPage
    {
        public User CurrentUser { get; set; }
        public RegisterUser()
        {
            CurrentUser = new User();
            InitializeComponent();
            BindingContext = this;
        }
        private async void Btn_Save(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            var result = client.UploadString("http://192.168.0.101:3245/api/Users/RegisterUser", JsonConvert.SerializeObject(CurrentUser));
            if (result != null)
            {
                
                await DisplayAlert("Message", "Registration was successful", "OK");
                await Navigation.PushAsync(new MainPage());
            }
            else
            {

            }



        }

        private async void Btn_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}