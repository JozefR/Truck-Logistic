
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace TruckLogistic
{
    partial class Program
    {
        public class TruckTransport : Transport
        {
            public List<TruckTransport> AcceptIncomingTrucks()
            {
                List<TruckTransport> trucks = JsonConvert.DeserializeObject<List<TruckTransport>>(
                  File.ReadAllText(@"C:\Users\randj\Dropbox\Truck-Logistic\TruckLogistic\TruckLogistic\Files\truck.json"));

                return trucks;
            }
        }
    }
}
