using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InsideScoopMobile
{
    public partial class TruckorUser : ContentPage
    {
        public TruckorUser()
        {
            InitializeComponent();
        }

        async void Truck_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new TruckSignUp());
        }

        async void User_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new UserSignUp());
        }
    }
}
