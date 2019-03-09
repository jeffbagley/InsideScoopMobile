using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InsideScoopMobile
{
    public partial class PasswordChange : ContentPage
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        async void Submit_Clicked(object sender, System.EventArgs e)
        {
            string oldPass = Old.Text;
            string newPass = New.Text;
            string confirmPass = Confirm.Text;


            await Navigation.PopAsync();
        }
    }
}
