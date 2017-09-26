
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckLogistic
{
    class Program
    {
        public interface ITruckLoader
        {
            dynamic AcceptIncomingTrucks(string path);
        }

        public abstract class Vehicle
        {
            private string _name;

            public Vehicle(string name)
            {
                _name = name;
            }

            public string GetName
            {
                get { return String.Format("{0}", _name ); }
            }
        }

        public abstract class CarryingVehicle : Vehicle
        {
            private int _carryingCapacity;
            private int _cargo;

            public CarryingVehicle(string name, int capacity, int cargo)
                :base(name)
            {
                _carryingCapacity = 100;
                _cargo = cargo;
            }
        }

        public class Truck : CarryingVehicle
        {
            private DateTime _arriveDate;
            private DateTime _leavingDate;

            public Truck(string name, DateTime arriveDate, DateTime leavingDate, int capacity, int cargo)
                :base(name, capacity, cargo)
            {
                _arriveDate = arriveDate;
                _leavingDate = leavingDate;
            }
        }

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
        }


        static void Main(string[] args)
        {
            TruckTransport transport = new TruckTransport();
            var transported = transport.AcceptIncomingTrucks(@"C:\Users\randj\Dropbox\Truck-Logistic\TruckLogistic\TruckLogistic\Files\truck.json");

            foreach (var truck in transported)
            {
                Console.WriteLine(truck.Name);
                Console.WriteLine(truck.Date);
            }

        }
    }
}
