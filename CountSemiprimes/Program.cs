using System;
using System.Collections.Generic;
using System.Linq;
using MiscUtils;

namespace CountSemiprimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p = { 1, 4, 16 };
            int[] q = { 26, 10, 20 };
            int n = 26;
            Console.WriteLine("result is: {0}", ArrayUtils.ToString(solution(n, p, q)));
            Console.Read();
        }

        public static int[] solution(int N, int[] P, int[] Q)
        {
            var primes = new Dictionary<int, int>();
            int i = 2, j;
            for (j = 0; j <= N; j++)
            {
                primes.Add(j, 0);
            }
            primes[0] = -1;
            while (i*i <= N)
            {
                if (primes[i] == 0)
                {
                    int k = i * i;
                    while (k <= N)
                    {
                        if (primes[k] == 0)
                            primes[k] = i;
                        k += i;
                    }
                }
                i++;
            }
            

            int[] res = new int[P.Length];
            for (i = 0; i < P.Length; i++)
            {
                for (j = P[i]; j <= Q[i]; j++)
                {
                    int n = primes[j];
                    if (n > 0 && primes[j / n] == 0)
                    {
                        res[i]++;
                    }
                }
            }
            return res;
        }
    }
}
