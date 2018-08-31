using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem7
    {
        public static void Solve()
        {
            Console.Write("10 001st prime number: " + Get10001PrimeNumber());

            Console.ReadLine();
        }

       static List<long> primeNumbers = new List<long>();

        static long Get10001PrimeNumber()
        {
            long i = 2;
            int k = 1;

            long prime = 5;

            while(k <= 10001)
            { 
                bool isPrime = true;

                for (long j = 2; j <= Math.Sqrt(i); j++) // you actually only need to check up to sqrt(i)
                {
                    if (i % j == 0) // you don't need the first condition
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeNumbers.Add(i);
                    if (k == 10001)
                    {
                        prime = i;
                    }

                    k++;
                }                

                i++;               
            }

            return primeNumbers.Last();
        }
    }
}
