using System;
using System.Collections.Generic;
using System.Linq;
using MiscUtils;

namespace NumberOfDiscIntersections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 2, 1, 4, 0 };
            Console.WriteLine("{0} discs intersected: {1}", ArrayUtils.ToString(a), solution(a));
            Console.Read();

        }

        public static int solution(int[] A)
        {
            if (A.Length == 0)
            {
                return 0;
            }
            long[] min = new long[A.Length];
            long[] max = new long[A.Length];

            for (long i = 0; i < A.Length; i++)
            {
                min[Math.Max(0, i - A[i])]++;
                max[Math.Min(A.Length - 1, i + A[i])]++;
            }

            long count = 0;
            long discAtIx = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (min[i] > 0)
                {
                    count += discAtIx * min[i] + (min[i] * (min[i] - 1) / 2);
                    if (count > 10000000)
                    {
                        return -1;
                    }
                    discAtIx += min[i];
                }
                discAtIx -= max[i];
            }
            return Convert.ToInt32(count);
        }

    }
}
