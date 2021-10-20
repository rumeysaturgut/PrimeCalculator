using System;
using System.Collections.Generic;

namespace PrimeNumberCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>();
            for (int i = 3; i < 10000000; i++)
            {
                if (IsGivenNumberPrime(i))
                    primeNumbers.Add(i);
            }
            Console.WriteLine(String.Join(", ",  primeNumbers));
        }
        
        private static bool IsGivenNumberPrime(int i)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                    return false;
            }
            return true;
        }
    }
}
