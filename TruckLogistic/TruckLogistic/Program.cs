using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckLogistic
{
    partial class Program
    {
        static void Main(string[] args)
        {
            TruckTransport truckTransport = new TruckTransport();
            CargoTransport cargoTransport = new CargoTransport();

            ProcessTransport transport = new ProcessTransport();
            
            transport.ProcessEvents(cargoTransport.AcceptIncomingCargo(),truckTransport.AcceptIncomingTrucks());
            

        }
    }
}