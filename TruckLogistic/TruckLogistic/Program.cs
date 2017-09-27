using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckLogistic
{
    partial class Program
    {


        static void Main(string[] args)
        {
            TruckTransport transport = new TruckTransport();

            System.Console.WriteLine(transport.TransportedTrucks());
        }
    }
}
