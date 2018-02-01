using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            printRes(new int[] { 3, 8, 9, 7, 6 }, 3);
            printRes(new int[] { 0, 0, 0 }, 1);
            printRes(new int[] { 1, 2, 3, 4 }, 4);
            printRes(new int[] { }, 1);
            printRes(new int[] { 2, 3 }, 5);
            Console.Read();
        }

        public static string arrToString(int[] a)
        {
            return string.Join(",", a.Select(x => x.ToString()).ToArray());
        }

        public static void printRes(int[] arr, int k)
        {
            Console.WriteLine(string.Format("array [{0}] rotated {1} times is: [{2}]", arrToString(arr), k, arrToString(solution(arr, k))));
        }

        public static int[] solution(int[] A, int K)
        {
            while (K > A.Length)
            {
                K = K - A.Length;
            }
            if (K == 0 || K == A.Length || A.Length == 0)
                return A;
            int[] res = new int[A.Length];
            Array.Copy(A, A.Length - K, res, 0, K);
            Array.Copy(A, 0, res, K, A.Length - K);
            return res;
        }
    }
}
