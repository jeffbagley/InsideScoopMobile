using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InsideScoopMobile
{
    public partial class TruckProfile : ContentPage
    {
        public TruckProfile()
        {
            InitializeComponent();
        }

        async void Edit_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EditTruckProfile());
        }

        async void Pass_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PasswordChange());
        }
    }
}
