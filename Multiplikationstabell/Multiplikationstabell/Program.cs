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
            Console.WriteLine("Skriv in ett tal och och sedan skrivs talets multiplikationstabell ut.");    //Skriver ut instruktioner
            string userInput = Console.ReadLine();  //gör en sträng som är lika med vad användaren skriver in
            int parsedInput = int.Parse(userInput); //omvandlar stängen till en integer
            int[] multiplikationer = new int[10];   //tabell som multiplicerar input med talen 1 till 10
            for (int i = 0; i < 10; i++)
            {
                multiplikationer[i] = (i+1) * parsedInput;
            }
            Console.WriteLine("Detta är ditt tals multiplikationstabell:");
            foreach(int nummer in multiplikationer) //skriver ut varje värde i tabellen som är talet multiplicerat med 1 - 10
            {
                Console.WriteLine(nummer);
            }
            Console.ReadLine();
        }
    }
}
