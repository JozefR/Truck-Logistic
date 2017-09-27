using System;

namespace TruckLogistic
{
    public class Truck : CarryingVehicle
    {
        private DateTime _arriveDate;
        private DateTime _leavingDate;

        public Truck(string name, DateTime arriveDate, DateTime leavingDate, int capacity, int cargo)
            : base(name, capacity, cargo)
        {
            _arriveDate = arriveDate;
            _leavingDate = leavingDate;
        }
    }
}
