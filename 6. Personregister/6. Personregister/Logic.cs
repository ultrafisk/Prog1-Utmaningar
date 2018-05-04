using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Personregister
{
    class Logic
    {
        PersonRegister register = new PersonRegister();
        public void Brain()
        {
            //Menyn. switch för inputs, om valet inte är 0,1,2 eller 'menu' så körs en metod som kollar om det finns några personer med det namnet
            Console.Write("Welcome user.\nThank you for choosing the Person Registrar 5000 !\nPlease select one of the options below:\n'0' Exit\n'1' See all registered persons\n'2' Add a person\n'menu' Show the menu\nOr type a name of a person to see their information\n");
            Menu();
            void Menu()
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        Environment.Exit(0);
                        break;

                    case "1":
                        SeeAll();
                        Menu();
                        break;

                    case "2":
                        register.Add();
                        Menu();
                        break;

                    case "menu":
                        Console.Write("\nPlease select one of the options below:\n'0' Exit\n'1' See all registered persons\n'2' Add a person\n'menu' Show the menu\nOr type a name of a person to see their information\n");
                        Menu();
                        break;

                    default:
                        FindPerson(input);
                        Menu();
                        break;
                }
            }

            void SeeAll()
            {
                //Hämtar listan med personarrayer
                List<Array> persons = register.SendList();

                Console.WriteLine();

                //För varje array i listan skrivs värdet på platsen 0 ut
                foreach(string[] value in persons)
                {
                    Console.WriteLine(value[0]);
                }
                Console.WriteLine("End of list.");
            }

            //tar in det användaren skrev i menyn
            void FindPerson(string input)
            {
                //tar in listan
                List<Array> persons = register.SendList();

                Console.WriteLine();

                //för varje string array i listan kollar den om det är lika med input, om samma så skrivs all info om personen ut
                foreach (string[] person in persons)
                {
                    if (person[0] == input)
                    {
                        foreach (string value in person)
                        {
                            Console.WriteLine(value);
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
