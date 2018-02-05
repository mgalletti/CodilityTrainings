using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiscUtils;

namespace NailingPlanks
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 1, 4, 5, 8 };
            //int[] b = { 4, 5, 9, 10 };
            //int[] c = { 4, 6, 7, 10, 2 };

            int[] a = { 2 };
            int[] b = { 2 };
            int[] c = { 1 };

            Console.WriteLine("number of nails: {0}", solution(a, b, c));
            Console.Read();
        }

        public static int solution(int[] A, int[] B, int[] C)
        {
            int min = C.Length + 1;
            int b = 1;
            int e = C.Length;

            max_length = Math.Max(Math.Max(A.Max(), B.Max()), C.Max());

            while (b <= e)
            {
                int m = (e + b) / 2;
                if (CheckNail(m, A, B, C))
                {
                    min = m;
                    e = m - 1;
                }
                else
                {
                    b = m + 1;
                }
            }

            return min == C.Length + 1 ? - 1 : min;
        }

        private static int max_length = 0;
        
        private static bool CheckNail(int ix, int[] A, int[] B, int[] C)
        {
            int[] ps = new int[max_length + 1];
            for (int i = 0; i < ix; i++)
                ps[C[i]]++;

            for (int i = 1; i < ps.Length; i++)
                ps[i] = ps[i] + ps[i - 1];

            bool[] nailed = new bool[A.Length];

            for (int j = 0; j < A.Length; j++)
            {
                if (ps[B[j]] != ps[A[j] - 1])
                {
                    nailed[j] = true;
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (!nailed[i])
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}
