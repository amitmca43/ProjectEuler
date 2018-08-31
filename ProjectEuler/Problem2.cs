using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem2
    {
        public static void Solve()
        {
            int prev1 = 1, prev2 = 2, current = 0;

            long evenSum = 2;
           while(current < 4000000)
            {
                current = prev1 + prev2;
                if(current % 2 ==0)
                {
                    evenSum += current;
                }

                prev1 = prev2;
                prev2 = current;

            }

            Console.Write("Fibonacci sequence whose values do not exceed four million, the sum of the even-valued terms: " + evenSum);
            Console.ReadLine();
        }
    }
}
