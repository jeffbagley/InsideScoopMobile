using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;
using Plugin.Geolocator;

namespace InsideScoopMobile
{


    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Pin> _pinCollection = new ObservableCollection<Pin>();
        public ObservableCollection<Pin> PinCollection { get { return _pinCollection; } set { _pinCollection = value; OnPropertyChanged(); } }

        private Position _myPosition = new Position(46.872131, -113.994019);
        public Position MyPosition { get { return _myPosition; } set { _myPosition = value; OnPropertyChanged(); } }


        public MainViewModel()
        {
            Task.Run(async () =>
            {
                var locator = CrossGeolocator.Current;
                var position = await locator.GetPositionAsync();
                MyPosition = new Position(position.Latitude, position.Longitude);
            });






            PinCollection.Add(new Pin() { Position = MyPosition, Type = PinType.Generic, Label = "I'm a Pin" });
        }





    }
}
