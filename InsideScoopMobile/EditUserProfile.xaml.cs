using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InsideScoopMobile
{
    public partial class EditUserProfile : ContentPage
    {
        public EditUserProfile()
        {
            InitializeComponent();
        }

        async void Submit_Clicked(object sender, System.EventArgs e)
        {
            string Email = mail.Text;
            await Navigation.PopAsync();
        }
    }
}
