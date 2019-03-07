using System;

using Xamarin.Forms;

namespace InsideScoopMobile
{
    public class ListPage2 : ContentPage
    {
        public ListPage2()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

