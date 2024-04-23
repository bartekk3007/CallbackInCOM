using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Klient2
{
    public class Handler : Klient2.ServiceReference1.IZadanie2Callback
    {
        public void Zadanie([MessageParameter(Name = "zadanie")] string zadanie1, int pkt, bool zaliczone)
        {
            Console.WriteLine($"{zadanie1} pkt: {pkt} zaliczone: {zaliczone}");
        }
    }

    public class Task2Client
    {
        public static void Main(string[] args)
        {
            var client2 = new Klient2.ServiceReference1.Zadanie2Client(new InstanceContext(new Handler()));
            client2.PodajZadania();
            Console.WriteLine("Program ended.");
            Console.ReadKey();

            ((IDisposable)client2).Dispose();
            Console.ReadKey();
        }
    }
}