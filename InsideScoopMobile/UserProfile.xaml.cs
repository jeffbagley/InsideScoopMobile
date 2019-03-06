using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InsideScoopMobile
{
    public partial class UserProfile : ContentPage
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        async void Pass_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
