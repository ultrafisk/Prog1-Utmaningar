using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Personregister
{
    class Person
    {
        //tar in strängar och gör om till array, returnerar
        public string[] Return(string name, string age, string city)
        {
            string[] info = new string[3];
            info[0] = name;
            info[1] = age;
            info[2] = city;

            return info;
        }
    }
}
