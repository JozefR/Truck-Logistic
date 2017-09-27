using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckLogistic
{
    public class Factory
    {
        private TruckTransport _truckTransport;
        private CargoTransport _cargotransport;
        private ProcessTransport _transport;

        public Factory()
        {
            _truckTransport = new TruckTransport();
            _cargotransport = new CargoTransport();
            _transport = new ProcessTransport();
        }

        public void StartWorking()
        {
            var events = ReceiveTransports();
            var sortEvents = events.OrderBy(e => e.Date);

            foreach (var eve in sortEvents)
            {
                if (eve.Name == "Cargo")
                {
                    Console.WriteLine(eve.Name);
                }

            }
        }


        private List<ProcessTransport> ReceiveTransports()
        {
            var events = _transport.ProcessEvents(_cargotransport.AcceptIncomingCargo(), _truckTransport.AcceptIncomingTrucks());
            return events;
        }


    }


    partial class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            factory.StartWorking();
        }
    }
}