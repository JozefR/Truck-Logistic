
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckLogistic
{
    class Program
    {


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


        static void Main(string[] args)
        {
            Truck truck = new Truck("Jozo",DateTime.Now,DateTime.Today,20,20);

            Console.WriteLine(truck.GetName);
        }
    }
}
