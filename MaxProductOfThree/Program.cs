using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiscUtils;

namespace MaxProductOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -3, 1, 2, -2, 5, 6 };
            Console.WriteLine("{0} max triplet product is: {1}", ArrayUtils.ToString(a), solution(a));
            a = new int[]{ -1000, 1, 2, -2, 5, 6};
            Console.WriteLine("{0} max triplet product is: {1}", ArrayUtils.ToString(a), solution(a));
            Console.Read();
        }

        public static int solution(int[] A)
        {
            Array.Sort(A);
            int p = A.Length - 3, q = A.Length - 2, r = A.Length - 1;
            int topMax = A[p] * A[q] * A[r];
            int bottomMax = 0;
            // checking negative numbers
            if (A[0] < 0 && A[1] < 0)
                bottomMax = A[0] * A[1] * A[A.Length - 1];

            return Math.Max(topMax, bottomMax);
        }
    }
}
