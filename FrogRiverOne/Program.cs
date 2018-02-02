using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 1, 4, 2, 3, 5, 4 };
            int n = 8, x = 5;
            Console.WriteLine("{0} frog reach {1} in {2} seconds", arrToString(a), x, solution(x, a, n));
            Console.Read();
        }

        public static string arrToString(int[] a)
        {
            return "[" + string.Join(",", a.Select(x => x.ToString()).ToArray()) + "]";
        }

        public static int solution(int X, int[] A, int N)
        {
            if (X > N)
            {
                return -1;
            }
            int tot = Enumerable.Range(1, X).Sum();
            int sum = 0;
            var leafs = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!leafs.Contains(A[i]))
                {
                    leafs.Add(A[i]);
                    sum += A[i];
                    if (sum == tot)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
