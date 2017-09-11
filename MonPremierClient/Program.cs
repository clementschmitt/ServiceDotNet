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
            var input = "";

            var client = new ServiceReference1.Service1Client();

            do
            {
                Console.WriteLine("Pour quel produit souhaitez-vous afficher le prix ?");
                Console.WriteLine("1 - Mario et lapins crétins");
                Console.WriteLine("2 - Assasins Creed Black Flag");

                input = Console.ReadLine();

                Console.WriteLine(input == "1" ? "Le prix du produit 'Mario et lapins crétins' est de " + client.GetPrice("Mario et lapins crétins").ToString() + "\n": 
                                  input == "2" ? "Le prix du produit 'Assasins Creed Black Flag' est de " + client.GetPrice("Assasins Creed Black Flag").ToString() + "\n": "\n");

            } while (input != "quit");

            client.Close();
        }
    }
}
