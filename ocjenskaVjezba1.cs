using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocjenskaVjezba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite string:");
            string input = Console.ReadLine();

            if (input.Length < 5)
            {
                Console.WriteLine("Rezultat: " + input);
            }
            else
            {
                string result = input.Substring(2, input.Length - 4);
                Console.WriteLine("Rezultat: " + result);
            }
            Console.ReadKey();
        }
    }
}
