﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subwaiiiiiii
{
    class Station1
    {
        //stationerna returnerar en integer som används i Train.cs för att bestämma vilken station som ska köras näst
        public int Station()
        {
            int output;
            Console.Write("\nWelcome to station 1!\nWhat would you like to do?\n1.Take the train to Station 2\n2.Leave\n");

            Parser parse = new Parser();

            int input = parse.Parse();
            if (input == 1)
            {
                output = 1;
                return output;
            }
            else if (input == 2)
            {
                output = 2;
                return output;
            }
            else
            {
                output = 0;
                return output;
            }
        }
    }
}
