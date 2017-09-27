using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace TruckLogistic
{
    public class CargoTransport : Transport
    {
        public CargoTransport()
        {
            Name = "Cargo";
        }

        public List<CargoTransport> AcceptIncomingCargo()
        {
            List<CargoTransport> cargo = JsonConvert.DeserializeObject<List<CargoTransport>>(
             File.ReadAllText(@"C:\Users\randj\Dropbox\Truck-Logistic\TruckLogistic\TruckLogistic\Files\cargo.json"));

            return cargo;
        }
    }
}

