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
            Dropdown.Items.Add("Candy");
            Dropdown.Items.Add("Breakfast");
            Dropdown.Items.Add("Lunch");
            Dropdown.Items.Add("Dinner");

        }

        async void Submit_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NavBar());
        }
    }
}
