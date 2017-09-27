using System;

namespace TruckLogistic
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
            get { return String.Format("{0}", _name); }
        }
    }

}
