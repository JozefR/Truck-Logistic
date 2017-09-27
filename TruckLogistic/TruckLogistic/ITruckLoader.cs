using System.Collections.Generic;

namespace TruckLogistic
{
    partial class Program
    {
        public interface ITransporTLoader
        {
            List<TruckTransport> AcceptIncomingTrucks();
            List<CargoTransport> AcceptIncomingCargo();
        }
    }
}
