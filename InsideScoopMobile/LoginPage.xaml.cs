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

            if(string.Compare(user, "Icecream@gmail.com") == 0) {
                await Navigation.PushAsync(new NavBar());

            }
            else if (string.Compare(user, "Customer@gmail.com") == 0)
            {
                await Navigation.PushAsync(new NavBarCustomer());
            }
        }

        async void SignUp_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new TruckorUser());
        }

        async void Guest_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NavBarGuest());
        }

    }
}
