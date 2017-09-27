namespace TruckLogistic
{
    public abstract class CarryingVehicle : Vehicle
    {
        private int _carryingCapacity;
        private int _cargo;

        public CarryingVehicle(string name, int capacity, int cargo)
            : base(name)
        {
            _carryingCapacity = 100;
            _cargo = cargo;
        }
    }
}

