using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem50
    {
        static int largestPrime = 0;

        public static void Solve()
        {         
            int[] primeNumbers = GetPrimeNumbers();
           
            int sum = 0;
            int count = 0;
            int length = primeNumbers.Length;           

            bool sumFound = false;
            int prime = 2;
            for (int i = 0; i < length; i++)
            {
                sum += primeNumbers[i];

                if(sum > largestPrime)
                {
                    sumFound = true;

                    sum -= primeNumbers[i];
                    count = 0;

                    if (IsPrime(sum))
                    {
                        prime = sum;
                        count = i - 1;
                        break;
                    }
                 
                    int tempSum = sum;

                    for (int j = i - 1; j > 0; j--)
                    {
                        tempSum = tempSum - primeNumbers[j];

                        if (IsPrime(tempSum))
                        {
                            if (j > count)
                            {
                                prime = tempSum;
                                count =  j;
                                break;
                            }
                        }
                    }

                    tempSum = sum;

                    for (int j = 0; j < i-1; j++)
                    {
                        tempSum = tempSum - primeNumbers[j];

                        if (IsPrime(tempSum))
                        {
                            if (i -1-j > count)
                            {
                                prime = tempSum;
                                count = i -1- j;
                                break;
                            }
                        }
                    }
                }
                else if (sum == largestPrime)
                {
                    count = i;
                    break;
                }

                if (sumFound)
                    break;
            }



            Console.Write("Prime, below one-million, which can be written as the sum of the most consecutive primes: " + prime);
            Console.ReadLine();
        }

        

        static int[] GetPrimeNumbers()
        {
            int primeSum = 0;
            List<int> primeNumbers = new List<int>(new int[] { 2, 3, 5 });

            for (int i = 6; i <= 1000000; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++) // you actually only need to check up to sqrt(i)
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
                    primeSum += i;
                    if (primeSum > 1000000)
                    {
                        largestPrime = primeSum - i;
                        break;
                    }
                }
            }

            return primeNumbers.ToArray();
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
