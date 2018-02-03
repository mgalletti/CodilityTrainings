using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiscUtils;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static int solution(int[] A)
        {
            Array.Sort(A);

            for (int i = 0; i < A.Length - 2; i++)
            {
                int p = i, q = i + 1, r = i + 2;
                if (CheckTriplet(A[p], A[q], A[r]))
                {
                    return 1;
                }
            }
            return 0;
        }
        
        public static bool CheckTriplet(int a, int b, int c)
        {
            return ((a + b > c) && (b + c > a) && (c + a > b)) || (a == b && b == c && a == Int32.MaxValue);
        }
    }
}
