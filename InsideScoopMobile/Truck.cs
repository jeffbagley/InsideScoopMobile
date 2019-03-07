using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
namespace InsideScoopMobile
{
    public class Truck
    {
        [JsonProperty(PropertyName = "BUSINESS_NAME")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "ACTIVE")]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "LAT")]
        public float Lat { get; set; }

        [JsonProperty(PropertyName = "LONG")]
        public string Long { get; set; }
    }
}
