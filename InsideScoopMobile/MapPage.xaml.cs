using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InsideScoopMobile
{
    public partial class MapPage : ContentPage
    {
        public MapPage( )
        {

            BindingContext = new MainViewModel();
            InitializeComponent();
        }
    }
}
