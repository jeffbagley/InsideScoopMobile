using System;
using System.Collections.Generic;
using System.Linq;

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


            if (!email.Contains("@")) 
            {
                Console.WriteLine("Invalid email: Must include @ symbol");
            }
            else if(!email.Contains("."))
            {
                Console.WriteLine("Invalid email: Must include . symbol");
            }
            else if(password.Length < 8)
            {
                Console.WriteLine("Password must be atleast 8 characters");
            }
            else if (!password.Any(char.IsUpper) || !password.Any(char.IsLower)) 
            {
                Console.WriteLine("Password must contain at least 1 upper and lower case letter");
            }
            else if(!password.Any(char.IsSymbol) && !password.Any(char.IsNumber) && !password.Any(char.IsPunctuation))
            {
                Console.WriteLine("Password must contain at least 1 number or symbol");
            }
            else if(password != confirmPass) 
            {
                Console.WriteLine("Password does not match confirm password");
            }
            else 
            {
                await Navigation.PushAsync(new NavBar());
            }




        }
    }
}
