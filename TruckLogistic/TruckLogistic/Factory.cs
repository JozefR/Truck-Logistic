using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckLogistic
{
    public class Factory
    {
        private TruckTransport _truckTransport;
        private CargoTransport _cargotransport;
        private ProcessTransport _transport;
        private List<Truck> _waitingTrucks;
        private List<Truck> _fullTrucks;
        private int _stock;

        public Factory()
        {
            _truckTransport = new TruckTransport();
            _cargotransport = new CargoTransport();
            _transport = new ProcessTransport();
            _waitingTrucks = new List<Truck>();
            _fullTrucks = new List<Truck>();
            _stock = 0;
        }

        public void StartWorking()
        {
            var events = ReceiveTransports();
            var sortEvents = events.OrderBy(e => e.Date);

            foreach (var eve in sortEvents)
            {
                if (eve.Name == "Cargo")
                {
                    _stock += eve.Capacity;
                }
                else
                {
                    DateTime arrivalDate = DateTime.Parse(eve.Date);
                    Truck truck = new Truck(eve.Name, arrivalDate, DateTime.Today, eve.Capacity);
                    _waitingTrucks.Add(truck);
                }

                while ((_waitingTrucks.Count != 0) && (_stock != 0))
                {
                    foreach (var trk in _waitingTrucks)
                    {
                        int capacity = trk.GetTruckCapacity() - trk.GetTruckCargo();
                        if (capacity > _stock)
                        {
                            trk.SetTruckCargo(_stock);
                            _stock -= _stock;
                        }
                        else
                        {
                            trk.SetTruckCargo(capacity);
                            trk.LeavingDate(DateTime.Parse(eve.Date));
                            _stock -= capacity;
                            _waitingTrucks.Remove(trk);
                            _fullTrucks.Add(trk);
                            break;
                        }
                    }
                }

            }
        }

        public void WaitingTrucks()
        {
            Console.WriteLine("Waiting trucks");
            Console.WriteLine();
            foreach (var truck in _waitingTrucks)
            {
                Console.WriteLine(truck.GetName);
            }
        }

        public void FullTrucks()
        {
            Console.WriteLine("Full Trucks");
            Console.WriteLine();
            foreach (var truck in _fullTrucks)
            {
                Console.WriteLine(truck.GetName);
            }
        }

        public void RestCargo()
        {
            Console.WriteLine();
            Console.WriteLine("Rest cargo... {0}", _stock);
        }


        private List<ProcessTransport> ReceiveTransports()
        {
            var events = _transport.ProcessEvents(_cargotransport.AcceptIncomingCargo(), _truckTransport.AcceptIncomingTrucks());
            return events;
        }
    }
}