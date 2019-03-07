using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;



namespace InsideScoopMobile
{
    public partial class TruckProfile : ContentPage
    {
        public Position position5 = new Position(46.861787, -113.985177);

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

        async void Location_Toggled(object sender, System.EventArgs e) 
        {
            await Navigation.PushAsync(new NavBar2());
        }

    }
}
