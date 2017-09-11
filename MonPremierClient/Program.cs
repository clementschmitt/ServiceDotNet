using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ServiceReference1.Service1Client();
            Console.WriteLine(client.GetPrice("Mario et lapins crétins"));

            Console.ReadLine();
        }
    }
}
