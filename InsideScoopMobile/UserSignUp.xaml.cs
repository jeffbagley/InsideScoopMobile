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
            string email = Email.Text;
            string password = Pass.Text;
            string confirmPass = Confirm.Text;


            await Navigation.PushAsync(new NavBar());

        }
    }
}
