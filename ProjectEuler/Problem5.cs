using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem5
    {
        public static void Solve()
        {
            long number = 2520;


            while (true)
            {
                if(number % 2 == 0 && number % 3 == 0 && number % 4 == 0 && number % 5 == 0 && number % 6 == 0 && number % 7 == 0 &&
                    number % 8 == 0 && number % 9 == 0 && number % 10 == 0 && number % 11 == 0 && number % 12 == 0 &&
                    number % 13 == 0 && number % 14 == 0 && number % 15 == 0 && number % 16 == 0 && number % 17 == 0 && number % 18 == 0 &&
                    number % 19 == 0 && number % 20 == 0 )
                {
                    break;
                }

                number++;
            }

            Console.Write("Smallest positive number that is evenly divisible by all of the numbers from 1 to 20: " + number);
            Console.ReadLine();
        }
    } 
}
