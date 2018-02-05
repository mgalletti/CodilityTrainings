using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 5, 1, 2, 2, 2 };
            int k = 3;
            int m = 5;
            Console.WriteLine("result is: {0}", solution(k, m, a));
            Console.Read();
        }

        public static int solution(int K, int M, int[] A)
        {
            // Binary search for the minimal size of a block. A valid block can be checked in a boolean fashion.
            int sum = A.Sum();
            int max = A.Max();

            if (K >= A.Length)
                return max;
            if (K == 1)
                return sum;

            int b = max;
            int e = sum;

            int min = sum;
            while (b <= e)
            {
                int m = (b + e) / 2;
                if (CheckSum(A, m, K))
                {
                    min = m;
                    e = m - 1;
                }
                else
                {
                    b = m + 1;
                }
            }
            return min;
        }

        public static bool CheckSum(int[] A, int candidate, int blockCount)
        {
            int sum = 0;
            int count = 0;
            foreach (var n in A)
            {
                if (sum + n > candidate)
                {
                    sum = n;
                    count++;
                }
                else
                {
                    sum += n;
                }
                if (count >= blockCount)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
