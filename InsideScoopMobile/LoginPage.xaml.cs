using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InsideScoopMobile
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Login_Clicked(object sender, System.EventArgs e)
        {
            string user = Email.Text;
            string password = Password.Text;

            Console.WriteLine(user);
            Console.WriteLine(password);

            if(string.Compare(user, "Cordell") == 0) {
                await Navigation.PushAsync(new NavBar());

            }
        }

        async void SignUp_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new TruckorUser());
        }

        void Guest_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
