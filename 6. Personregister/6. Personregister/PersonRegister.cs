using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Personregister
{
    class PersonRegister
    {
        Person person = new Person();
        public List<Array> persons = new List<Array>();

        //tar in input, skickar till Person.cs, lägger till arrayen i listan
        public void Add()
        {
            Console.WriteLine("\nYou have chosen to add a person.\nWhat is the persons name?");
            string name = Console.ReadLine();
            Console.WriteLine("Age?");
            string age = Console.ReadLine();
            Console.WriteLine("City?");
            string city = Console.ReadLine();

            string[] info = person.Return(name, age, city);

            persons.Add(info);

            Console.WriteLine("Person added.");
        }

        //skickar listan
        public List<Array> SendList()
        {
            return persons;
        }
    }
}
