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
        // static List<long> TriangleNumbers;
        static int currentIndex;
        static long currentTriNumber;
        public static void Solve()
        {
            // var x = getFactorCount(28);
            currentIndex = 0;
            currentTriNumber = 1;
            // TriangleNumbers = new List<long>();
            // TriangleNumbers.Add(currentTriNumber);
            long factorCount = 0;
            while (factorCount < 500)
            {
                getNextTriNum();
                factorCount = getFactorCount(currentTriNumber);
            }

            Console.WriteLine("Solution: {0}", currentTriNumber);
        }

        static void getNextTriNum()
        {
            currentIndex++;
            long sum = 0;
            for (int j = 1; j <= currentIndex; j++)
            {
                sum += j;
            }
            currentTriNumber = sum;
            // TriangleNumbers.Add(currentTriNumber);
        }
        static int getFactorCount(long n)
        {
            List<int> factors = new List<int>();

            for (int j = 1; j <= n; j++)
            {
                if (n % j == 0)
                {
                    factors.Add(j);
                }
            }
            return factors.Count;
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