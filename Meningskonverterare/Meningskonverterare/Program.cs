using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meningskonverterare
{
    class Program           //Erik Hackeru, also everything here is simples so no need for comment
    {
        static void Main(string[] args)
        {
            Console.Write("Thou art welcome fellow traveller.\nTake a seat by the fire, tell us a story, and we shall ascend it to a higher state of supremacy.\n");
            WordMaster();
            Console.ReadLine();
        }
        static void WordMaster()
        {
            Console.Write("What does'th thou want:\n1.lower case\n2.UPPER CASE\n");
            string input;
            string output;
            int choice;
            bool parse = int.TryParse(Console.ReadLine(), out choice);
            if (!parse)
            {
                Console.WriteLine("You could not have made a worse choice, imbecile.\nTry again.");
                WordMaster();
            }
            if (choice == 1)
            {
                Console.Write("Thou has'th chosen lower case.\nWrite thine sentence down below:\n");
                input = Console.ReadLine();
                output = input.ToLower();       //exept this :)    .ToLower() or .ToUpper() converts to upper or lower case characters
                Console.WriteLine(output);
            }
            else if (choice == 2)
            {
                Console.Write("Thou has'th chosen UPPER CASE.\nWrite thine sentence down below:\n");
                input = Console.ReadLine();
                output = input.ToUpper();
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("You chose... poorly.");
                WordMaster();
            }
            WordMaster();
        }
    }
}
