using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem6
    {
        public static void Solve()
        {           
            long sum = 0;

            long sum100 = (100 * 101) / 2;
            long sumSqaure = sum100 * sum100;

            long diff = 0;

            for (int i = 1; i <= 100; i++)
            {                
                sum += i*i;                
            }

            diff = sumSqaure - sum;

            Console.Write("difference between the sum of the squares of the first one hundred natural numbers and the square of the sum: " + diff);
            Console.ReadLine();
        }
    }
}
