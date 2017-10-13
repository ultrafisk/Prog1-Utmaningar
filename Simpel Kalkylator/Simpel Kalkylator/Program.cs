using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpel_Kalkylator //Erik Hacker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hej!");

            MathChoice();

            Console.ReadLine();
        }
        static void MathChoice()
        {
            Console.Write("Välj ett räknesätt:\n1.Addition\n2.Subtraktion\n3.Multiplikation\n");

            int tal;
            bool inputValid = int.TryParse(Console.ReadLine(), out tal);

            if (!inputValid)
            {
                Console.WriteLine("Felaktigt input, försök igen.");
                MathChoice();
            }

            if (tal == 1)
            {
                Addition();
            }
            else if (tal == 2)
            {
                Subtraktion();
            }
            else if (tal == 3)
            {
                Multiplikation();
            }
            else
            {
                Console.WriteLine("Felaktigt val, försök igen:");
                MathChoice();
            }
        }
        static void Addition()
        {
            Console.WriteLine("Skriv ditt första tal: ");

            int input1;
            bool input1Valid = int.TryParse(Console.ReadLine(), out input1);

            if (!input1Valid)
            {
                Console.WriteLine("Felaktigt tal, försök igen.");
                Addition();
            }

            Console.WriteLine("Skriv in ditt andra tal: ");

            int input2;
            bool input2Valid = int.TryParse(Console.ReadLine(), out input2);

            if (!input2Valid)
            {
                Console.WriteLine("Felaktigt tal, försök igen.");
                Addition();
            }

            int output = input1 + input2;
            Console.WriteLine($"{input1} + {input2} = {output}");
        }
        static void Subtraktion()
        {
            
        }
        static void Multiplikation()
        {

        }
    }
}
