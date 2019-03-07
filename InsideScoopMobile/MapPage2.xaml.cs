using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InsideScoopMobile
{
    public partial class MapPage2 : ContentPage
    {
        public MapPage2()
        {

            BindingContext = new MainViewModel2();
            InitializeComponent();
        }
    }
}
