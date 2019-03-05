using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InsideScoopMobile
{
    public partial class EditTruckProfile : ContentPage
    {
        public EditTruckProfile()
        {
            InitializeComponent();
        }

        async void Submit_Clicked(object sender, System.EventArgs e) 
        {
            string name = Name.Text;
            string type = FoodType.Text;
            string email = Email.Text;

            await Navigation.PopAsync();

        
        
        }
    }
}
