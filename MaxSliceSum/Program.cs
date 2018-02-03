using System;
using System.Collections.Generic;
using System.Linq;
using MiscUtils;

namespace MaxSliceSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 3, 2, -6, 4, 0 };
            int[] a = { -10 };
            Console.WriteLine("{0} max slice sum is: {1}", ArrayUtils.ToString(a), solution(a));
            Console.Read();
        }

        public static int solution(int[] A)
        {
            int max_ending = A[0];
            int result = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                max_ending = Math.Max(A[i], max_ending + A[i]);
                result = Math.Max(result, max_ending);
            }
            return result;
        }
    }
}
