﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subwaiiiiiii
{
    class Parser
    {
        //En parse metod som kan tillkallas från överallt med hjälp av objekt
        public int Parse()
        {
            int input;
            bool valid = int.TryParse(Console.ReadLine(), out input);
            if (!valid)
            {
                input = 0;
                return input;
            }
            else
            {
                return input;
            }
        }
    }
}
