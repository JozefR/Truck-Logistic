namespace TruckLogistic
{
    public abstract class CarryingVehicle : Vehicle
    {
        private int _carryingCapacity;
        private int _cargo;

        public CarryingVehicle(string name, int cargo)
            : base(name)
        {
            _carryingCapacity = 100;
            _cargo = cargo;
        }

        public virtual int GetTruckCapacity()
        {
            return _carryingCapacity;
        }

        public virtual int GetTruckCargo()
        {
            return _cargo;
        }

        public virtual void SetTruckCargo(int cargo)
        {
            if (cargo > _carryingCapacity)
                throw new System.Exception("The cargo is too heavy for the truck!");

            _cargo += cargo;
        }
    }
}

