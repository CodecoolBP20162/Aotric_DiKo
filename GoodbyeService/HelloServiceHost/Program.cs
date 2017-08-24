using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace GoodbyeServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("           wwwwww     ");
            using (ServiceHost host = new ServiceHost(typeof(GoodbyeService.GoodbyeService)))
            {
                host.Open();
                Console.WriteLine("Host started @" + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
