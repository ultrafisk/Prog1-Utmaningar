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
            //Skriver Hej
            Console.Write("Hej!");

            //Kör Metoden MathChoice
            MathChoice();

            Console.ReadLine();
        }
        static void MathChoice()
        {
            //Skriver Valen
            Console.Write("Välj ett räknesätt:\n1.Addition\n2.Subtraktion\n3.Multiplikation\n");

            //Kollar input och parse-ar
            int val;

            bool inputValid = int.TryParse(Console.ReadLine(), out val);

            if (!inputValid)
            {
                Console.WriteLine("Felaktigt tal, försök igen.");
                MathChoice();
            }

            //Kollar valet och kör tillhörande metod eller skriver om det är ett felaktigt val
            if (val == 1)
            {
                Addition();
            }
            else if (val == 2)
            {
                Subtraktion();
            }
            else if (val == 3)
            {
                Multiplikation();
            }
            else
            {
                Console.WriteLine("Felaktigt val, försök igen:");
                MathChoice();
            }

            //Kör denna metod igen
            MathChoice();
        }

        //Tar input och adderar dem
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

        //tar input och subtraherar dem
        static void Subtraktion()
        {
            Console.WriteLine("Skriv ditt första tal: ");

            int input1;

            bool input1Valid = int.TryParse(Console.ReadLine(), out input1);

            if (!input1Valid)
            {
                Console.WriteLine("Felaktigt tal, försök igen.");
                Subtraktion();
            }

            Console.WriteLine("Skriv in ditt andra tal: ");

            int input2;
            bool input2Valid = int.TryParse(Console.ReadLine(), out input2);

            if (!input2Valid)
            {
                Console.WriteLine("Felaktigt tal, försök igen.");
                Subtraktion();
            }

            int output = input1 - input2;
            Console.WriteLine($"{input1} - {input2} = {output}");
        }

        //tar input och multiplicerar dem
        static void Multiplikation()
        {
            Console.WriteLine("Skriv ditt första tal: ");

            int input1;

            bool input1Valid = int.TryParse(Console.ReadLine(), out input1);

            if (!input1Valid)
            {
                Console.WriteLine("Felaktigt tal, försök igen.");
                Multiplikation();
            }

            Console.WriteLine("Skriv in ditt andra tal: ");

            int input2;
            bool input2Valid = int.TryParse(Console.ReadLine(), out input2);

            if (!input2Valid)
            {
                Console.WriteLine("Felaktigt tal, försök igen.");
                Multiplikation();
            }

            int output = input1 * input2;
            Console.WriteLine($"{input1} * {input2} = {output}");
        }
    }
}