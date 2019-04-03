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
            Dropdown.Items.Add("American");
            Dropdown.Items.Add("Asian");
            Dropdown.Items.Add("Beverage");
            Dropdown.Items.Add("Ice Cream");
            Dropdown.Items.Add("Mexican");
        }

        async void Submit_Clicked(object sender, System.EventArgs e) 
        {
            string name = Name.Text;

            string email = Email.Text;

            string type = Dropdown.Items[Dropdown.SelectedIndex];
            Console.WriteLine(type);
            await Navigation.PopAsync();


        
        
        }
    }
}
