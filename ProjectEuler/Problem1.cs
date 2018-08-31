using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem1
    {
        public static void Solve()
        {
            int sum = 0;
            for (int i = 3; i < 1000; i++)
            {
                if (i % 3 == 0  || i%5 == 0)
                {
                    sum += i;
                }
            }

            Console.Write("Sum of all the multiples of 3 or 5 below 1000: " + sum);
            Console.ReadLine();
        }
    }
}
