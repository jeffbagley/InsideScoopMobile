﻿using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace InsideScoopMobile
{
    public partial class TruckSignUp : ContentPage
    {
        public TruckSignUp()
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
            string name = Truck.Text;
            


            string numb = Number.Text;

            string email = Email.Text;
            string type = Dropdown.Items[Dropdown.SelectedIndex];
            string password = Pass.Text;
            string confirmPass = Confirm.Text;

            if (!email.Contains("@"))
            {
                Errors.Text = "Invalid Email: Must include @ symbol";

                Console.WriteLine("Invalid email: Must include @ symbol");
            }
            else if (!email.Contains("."))
            {
                Errors.Text = "Invalid email: Must include . symbol";
                Console.WriteLine("Invalid email: Must include . symbol");
            }
            else if (password.Length < 8)
            {
                Errors.Text = "Password must be atleast 8 characters";
                Console.WriteLine("Password must be atleast 8 characters");
            }
            else if (!password.Any(char.IsUpper) || !password.Any(char.IsLower))
            {
                Errors.Text = "Password must contain at least 1 upper and lower case letter";
                Console.WriteLine("Password must contain at least 1 upper and lower case letter");
            }
            else if (!password.Any(char.IsSymbol) && !password.Any(char.IsNumber) && !password.Any(char.IsPunctuation))
            {
                Errors.Text = "Password must contain at least 1 number or symbol";
                Console.WriteLine("Password must contain at least 1 number or symbol");
            }
            else if (password != confirmPass)
            {
                Errors.Text = "Password does not match confirm password";
                Console.WriteLine("Password does not match confirm password");
            }
            else if (name.Length > 30 || name.Length == 0)
            {
                Errors.Text = "Truck name must be 1-30 charcters in length";
                Console.WriteLine("Truck name must be 1-30 charcters in length");
            }
            else if (numb.Length > 9 || numb.Length < 9)
            {
                Errors.Text = "EIN must be 9 numbers long";
                Console.WriteLine("EIN must be 9 numbers long");
            }
            else
            {
                await Navigation.PushAsync(new NavBar());
            }





        }
    }
}
