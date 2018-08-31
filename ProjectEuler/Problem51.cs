using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem51
    {
        public static void Solve()
        {           



            Console.Write("Smallest prime which, by replacing part of the number (not necessarily adjacent digits) with the same digit, is part of an eight prime value family: ");
            Console.ReadLine();
        }

        static bool IsPrime(int number)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(number); j++)
            {
                if (number % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }


}
