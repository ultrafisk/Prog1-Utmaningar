using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplikationstabell
{
    class Program   //Erik Hacker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplikationstabellinator-5 Billion");
            Console.WriteLine("Skriv in ett tal och och sedan skrivs talets multiplikationstabell ut.");
            string userInput = Console.ReadLine();
            int parsedInput = int.Parse(userInput);
            int[] multiplikationer = new int[10];
            for (int i = 0; i < 10; i++)
            {
                multiplikationer[i] = (i+1) * parsedInput;
            }
            foreach(int nummer in multiplikationer)
            {
                Console.WriteLine(nummer);
            }
            Console.ReadLine();
        }
    }
}
