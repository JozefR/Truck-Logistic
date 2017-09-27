using System;

namespace TruckLogistic
{
    public class Truck : CarryingVehicle
    {
        private DateTime _arriveDate;
        private DateTime _leavingDate;

        public Truck(string name, DateTime arriveDate, DateTime leavingDate, int cargo)
            : base(name, cargo)
        {
            _arriveDate = arriveDate;
            _leavingDate = leavingDate;
        }

        public void LeavingDate(DateTime time)
        {
            _leavingDate = time;
        }
    }
}
