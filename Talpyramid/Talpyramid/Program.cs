using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talpyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ett tal: ");

            int input;
            bool validInput = int.TryParse(Console.ReadLine(), out input);
            if (!validInput)
            {
                Console.WriteLine("Ogiltigt Input");
                Main(args);
            }

            Console.WriteLine("Hej");

            Console.ReadLine();
        }
    }
}
