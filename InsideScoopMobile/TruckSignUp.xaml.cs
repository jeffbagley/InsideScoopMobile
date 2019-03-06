using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InsideScoopMobile
{
    public partial class TruckSignUp : ContentPage
    {
        public TruckSignUp()
        {
            InitializeComponent();
        }

        async void Submit_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NavBar());
        }
    }
}
