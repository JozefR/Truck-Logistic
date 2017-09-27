
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace TruckLogistic
{
    partial class Program
    {
        public class TruckTransport : ITruckLoader
        {
            public string Name { get; set; }
            public string Date { get; set; }

            public dynamic AcceptIncomingTrucks(string path)
            {
                List<TruckTransport> trucks = JsonConvert.DeserializeObject<List<TruckTransport>>(
                  File.ReadAllText(path));

                return trucks;
            }

            public List<TruckTransport> TransportedTrucks()
            {
                TruckTransport transport = new TruckTransport();
                var transported = transport.AcceptIncomingTrucks(@"C:\Users\randj\Dropbox\Truck-Logistic\TruckLogistic\TruckLogistic\Files\truck.json");
                return transported;
            }
        }
    }
}
