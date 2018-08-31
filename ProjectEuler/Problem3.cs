using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem3
    {
        static long number = 600851475143;
        static double primeLimit = Math.Sqrt(600851475143);
        public static void Solve()
        {
            long dividend = number;
            GetPrimeNumbers();
            List<long> primeFactors = new List<long>();

            long largestFactor = 3;

            foreach (var factor in primeNumbers)
            {
                if (dividend % factor == 0)
                {
                    dividend = dividend / factor;
                    primeFactors.Add(factor);
                    if (factor > largestFactor)
                        largestFactor = factor;

                    if(dividend == 1)
                    {
                        break;
                    }
                }
            }




            Console.Write("Largest prime factor of the number 600851475143: " + largestFactor);
            Console.ReadLine();
        }

        static List<long> primeNumbers = new List<long>(new long[]{2,3,5});

        static void GetPrimeNumbers()
        {
            for (long i = 6; i <= primeLimit; i++)
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
               
                if(isPrime)
                {
                    primeNumbers.Add(i);
                }
            }
        }
    }
}
