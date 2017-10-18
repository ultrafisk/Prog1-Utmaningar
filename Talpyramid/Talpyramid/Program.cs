using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talpyramid
{
    class Program           //Erik Hacker
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ett tal: ");

            // ---- PARSE ----
            // omvandlar readline till integern "input"
            int input;
            bool validInput = int.TryParse(Console.ReadLine(), out input);
            if (!validInput)
            {
                Console.WriteLine("Ogiltigt Input");
                Main(args);
            }

            // ---- PYRAMID ----
            //för varje i så skiver den inre loopen ut "input" i antal gånger
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{input}");
                }

                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
