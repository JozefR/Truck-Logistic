using System.Text;
using System.Threading.Tasks;

namespace TruckLogistic
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            factory.StartWorking();
            factory.FullTrucks();
            factory.WaitingTrucks();
            factory.RestCargo();
        }
    }
}