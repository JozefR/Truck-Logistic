using System.Collections.Generic;

namespace TruckLogistic
{
    public class ProcessTransport : Transport
    {
        public List<ProcessTransport> ProcessEvents(List<CargoTransport> cargosTransport, List<TruckTransport> truckTransport)
        {
            List<ProcessTransport> events = new List<ProcessTransport>();

            foreach (var truck in truckTransport)
            {
                ProcessTransport transport = new ProcessTransport();
                transport.Capacity = truck.Capacity;
                transport.Date = truck.Date;
                transport.Name = truck.Name;
                events.Add(transport);
            }

            foreach (var cargo in cargosTransport)
            {
                ProcessTransport transport = new ProcessTransport();
                transport.Name = cargo.Name;
                transport.Date = cargo.Date;
                transport.Capacity = cargo.Capacity;
                events.Add(transport);
            }
            return events;
        }
    }
}