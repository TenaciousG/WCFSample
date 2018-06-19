using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFConsumerCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contacting WCFService...");
            var service1Client = new Service1Client();
            var data = service1Client.GetData(3);
            Console.WriteLine($"Got result: {data}");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
