using System;
using System.Collections.Generic;
using System.Linq;

/* 
    What is the value of the first triangle number to have over five hundred divisors?
    https://projecteuler.net/problem=12  */


namespace EulerCore2
{
    static class HighlyDivisibleTriangularNumber
    {
        static List<long> TriangleNumbers;
        static int i;
        static List<int> primes;
        public static void Solve()
        {
            primes = Tools.GetPrimes();
            i = 0;
            TriangleNumbers = new List<long>();


            Console.WriteLine("Solution: {0}", 0);
        }

        static void getNextTriNum()
        {
            i++;
            long sum = 0;
            for (int j = 1; i <= i + 1;j++)
            {
                sum += i;
            }
            TriangleNumbers.Add(sum);
        }
        static int getFactorCount(long n)
        {
            List<int> factors = new List<int>();
            

            return 0;
        }
    }
}

// public static List<long> GetTriNums()
// {
//     List<long> result = new List<long>();
//     long tempSum;
//     for (int i = 1; i < int.MaxValue/2; i++)
//     {
//         tempSum = 0;
//         for (int j = 1; j <= i; j++)
//         {
//             tempSum += j;
//         }
//         result.Add(tempSum);
//     }
//     return result;
// }