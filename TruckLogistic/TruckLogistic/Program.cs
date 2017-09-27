using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckLogistic
{
    partial class program
    {
        static void Main(string[] args)
        {

            TruckTransport transport = new TruckTransport();
            CargoTransport cargoTransport = new CargoTransport();

            Console.WriteLine("trucks");

            foreach (var truck in transport.AcceptIncomingTrucks())
            {
                Console.WriteLine(truck.Name);
                Console.WriteLine(truck.Date);
                Console.WriteLine(truck.Capacity);
            }

            Console.WriteLine("cargo");

            foreach (var cargo in cargoTransport.AcceptIncomingCargo())
            {
                Console.WriteLine(cargo.Name);
                Console.WriteLine(cargo.Date);
                Console.WriteLine(cargo.Capacity);
            }

        }
    }
}