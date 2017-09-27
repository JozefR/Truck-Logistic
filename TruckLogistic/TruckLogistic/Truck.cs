using System;

namespace TruckLogistic
{
    partial class Program
    {
        public class Truck : CarryingVehicle
        {
            private DateTime _arriveDate;
            private DateTime _leavingDate;
            private TruckTransport _truckTransport;

            public Truck(string name, DateTime arriveDate, DateTime leavingDate, int capacity, int cargo)
                :base(name, capacity, cargo)
            {
                _arriveDate = arriveDate;
                _leavingDate = leavingDate;
            }
        }
    }
}
