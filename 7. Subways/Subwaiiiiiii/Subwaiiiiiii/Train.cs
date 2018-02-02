using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subwaiiiiiii
{
    class Train
    {
        public void Locomotive()
        {
            Station1 stat1 = new Station1();
            Station2 stat2 = new Station2();
            Station3 stat3 = new Station3();

            Station1();

            void Station1()
            {
                int choice = stat1.Station();

                if (choice == 1)
                {
                    Station2();
                }
                else if (choice == 2)
                {
                    Exit();
                }
                else
                {
                    Console.Write("\nu r invalid choose\n");
                    Station1();
                }
            }

            void Station2()
            {
                int choice = stat2.Station();

                if (choice == 1)
                {
                    Station3();
                }
                else if (choice == 2)
                {
                    Station1();
                }
                else if (choice == 3)
                {
                    Exit();
                }
                else
                {
                    Console.Write("\nu r invalid choose\n");
                    Station2();
                }
            }

            void Station3()
            {
                int choice = stat3.Station();

                if (choice == 1)
                {
                    Station2();
                }
                else if (choice == 2)
                {
                    Exit();
                }
                else
                {
                    Console.Write("\nu r invalid choose\n");
                    Station3();
                }
            }

            void Exit()
            {
                Environment.Exit(0);
            }
        }
    }
}
