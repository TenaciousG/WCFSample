using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using WCFSample;

namespace WCFConsoleRun
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebServiceHost(typeof(Service1), new Uri("http://localhost:8000"));
            ServiceEndpoint ep = host.AddServiceEndpoint(typeof(IService1), new WebHttpBinding(), "Test");

            ServiceDebugBehavior sdb = host.Description.Behaviors.Find<ServiceDebugBehavior>();
            sdb.HttpHelpPageEnabled = false;

            host.Open();
            Console.WriteLine("Service is running");
            Console.WriteLine("Press enter to quit...");
            Console.ReadLine();
            host.Close();
        }
    }
}
