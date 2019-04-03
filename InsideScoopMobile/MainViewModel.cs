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

        private Position _myPosition = new Position(46.861787, -113.985177);
        public Position MyPosition { get { return _myPosition; } set { _myPosition = value; OnPropertyChanged(); } }

        public Position position2 = new Position(46.855242, -113.993256);
        public Position position3 = new Position(46.869931, -113.996852);
        public Position position4 = new Position(46.862399, -114.008904);
        public Position position5 = new Position(46.861787, -113.985177);

        public MainViewModel( )
        {
            Task.Run(async () =>
            {
                var locator = CrossGeolocator.Current;
                var position = await locator.GetPositionAsync();
                MyPosition = new Position(position.Latitude, position.Longitude);
            });




            PinCollection.Add(new Pin() { Position = position2, Type = PinType.Generic, Label = "Taco Truck" });
            PinCollection.Add(new Pin() { Position = position3, Type = PinType.Generic, Label = "Noodle Wagon" });
            PinCollection.Add(new Pin() { Position = position4, Type = PinType.Generic, Label = "Ice Cream 4Ever" });


        }





    }
}
