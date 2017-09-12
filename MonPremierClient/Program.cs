using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierClient
{
    class Program
    {
        static async void MaMethodeAsynchrone(string input, ServiceReference1.Service1Client client)
        {
            Console.WriteLine($"Le prix du produit {input} est de {await client.GetPriceAsync(input)}");
            
        }
        static void Main(string[] args)
        {
            var input = "";

            var client = new ServiceReference1.Service1Client();

            do
            {
                Console.WriteLine("Quel produit souhaitez-vous afficher le prix ?");
                Console.WriteLine("1 - Mario et les lapins Crétins");
                Console.WriteLine("2 - PS4");
                Console.WriteLine("3 - Assasins Creed");
                Console.WriteLine("4 - Far Cry 5");
                Console.WriteLine("5 - Destiny 2");
                Console.WriteLine("6 - Overwatch");
                Console.WriteLine("7 - League of Legends");
                
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Task.Run(() => MaMethodeAsynchrone("Mario et les lapins Crétins", client));
                        break;
                    case "2":
                        Task.Run(() => MaMethodeAsynchrone("PS4", client));
                        break;
                    case "3":
                        Task.Run(() => MaMethodeAsynchrone("Assasins Creed", client));
                        break;
                    case "4":
                        Task.Run(() => MaMethodeAsynchrone("Far Cry 5", client));
                        break;
                    case "5":
                        Task.Run(() => MaMethodeAsynchrone("Destiny 2", client));
                        break;
                    case "6":
                        Task.Run(() => MaMethodeAsynchrone("Overwatch", client));
                        break;
                    case "7":
                        Task.Run(() => MaMethodeAsynchrone("League of Legends", client));
                        break;
                    default:
                        Task.Run(() => MaMethodeAsynchrone("", client));
                        break;
                }

            } while (input != "quit");

            client.Close();
        }
    }
}
