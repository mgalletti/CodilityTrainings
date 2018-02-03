using System;
using System.Collections.Generic;
using System.Linq;
using MiscUtils;

namespace MaxDoubleSliceSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 2, 6, -1, 4, 5, -1, 2 };
            //int[] a = { -10 };
            Console.WriteLine("{0} max double slice sum is: {1}", ArrayUtils.ToString(a), solution(a));
            Console.Read();
        }
        /*
         * We can use Kadane’s algorithm from two directions. First, we can safely ignore A[0] and A[N-1] since by definition they can’t be a part of any double-slice sum.
         * 
         * Now, define K1[i] as the maximum sum contiguous subsequence ending at index i, and similarly, 
         * define K2[i] as the maximum sum contiguous subsequence starting with index i.
         * 
         * Then, iterate over i, and find the maximum sum of K1[i-1]+K2[i+1]. This is the max double slice sum.
        */
        public static int solution(int[] A)
        {
            int N = A.Length;
            int[] a1 = new int[N];
            int[] a2 = new int[N];
            for (int i = 1; i < N-1; i++)
            {
                a1[i] = Math.Max(0, a1[i-1] + A[i]);
            }
            for (int i = N-2; i > 0; i--)
            {
                a2[i] = Math.Max(0, a2[i + 1] + A[i]);
            }
            int result = 0;
            for (int i = 1; i < N-1; i++)
            {
                result = Math.Max(result, a1[i-1] + a2[i+1]);
            }
            return result;
        }
    }
}
