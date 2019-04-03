using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InsideScoopMobile
{
    public partial class ListTab2 : ContentPage
    {
        public ListTab2()
        {
            InitializeComponent();
            Dropdown.Items.Add("Nearest");
            Dropdown.Items.Add("Food Type");
            Dropdown.Items.Add("Rating");
            Dropdown.Items.Add("Favorites");
        }

        async void Handle_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ViewTruck());
        }

        async void Handle_Taco(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new TacoTruck());
        }
    }
}