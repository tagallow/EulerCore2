using System;
using System.IO;
using System.Collections.Generic;
namespace EulerCore2
{
    static class Tools
    {
        public static List<int> GetPrimes10k()
        {
            return SieveEratosthenes(104730);
        }
        public static List<int> GetPrimes(int max = 7920)
        {
            return SieveEratosthenes(max);
        }
        public static List<int> SieveEratosthenes(int max)
        {
            bool[] N = new bool[max];
            for (int i = 0; i < N.Length; i++)
                N[i] = true;
            N[0] = N[1] = false;

            for (int i = 2; i < N.Length; i++)
            {
                if (N[i])
                {
                    for (int j = (2 * i); j < N.Length; j += i)
                    {
                        N[j] = false;
                    }
                }
            }
            List<int> result = new List<int>();
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i])
                {
                    result.Add(i);
                }
            }
            return result;
        }
        #region unused
        private static int[] GetPrimesFile()
        {
            string[] file = File.ReadAllLines(@"Tools\1kprimes.txt")[0].Split(',');
            int[] primes = Array.ConvertAll(file, int.Parse);
            return primes;
        }
        private static int[] GetPrimes10kFile()
        {
            string[] file = File.ReadAllLines(@"Tools\10kprimes.txt")[0].Split(',');
            int[] primes = Array.ConvertAll(file, int.Parse);
            return primes;
        }
        #endregion

    }
}