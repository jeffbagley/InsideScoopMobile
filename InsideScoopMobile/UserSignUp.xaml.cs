using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InsideScoopMobile
{
    public partial class UserSignUp : ContentPage
    {
        public UserSignUp()
        {
            InitializeComponent();
        }

        async void Submit_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NavBar());

        }
    }
}
