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
            Dropdown.Items.Add("American");
            Dropdown.Items.Add("Asian");
            Dropdown.Items.Add("Beverage");
            Dropdown.Items.Add("Ice Cream");
            Dropdown.Items.Add("Mexican");

        }

        async void Submit_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NavBar());
        }
    }
}
