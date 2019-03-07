using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace InsideScoopMobile
{
    public class TruckManager
    {
        IMobileServiceTable<Truck> todoTable;
        MobileServiceClient client;

        public TruckManager()
        {
            client = new MobileServiceClient("https://insidescoopmobile.azurewebsites.net");
            todoTable = client.GetTable<Truck>();

        }

        public async Task<ObservableCollection<Truck>> GetTruckAsync(bool syncItems = false)
        {
            IEnumerable<Truck> items = await todoTable
              .Where(Truck => !Truck.Active)
              .ToEnumerableAsync();

            return new ObservableCollection<Truck>(items);
        }
    }
}
