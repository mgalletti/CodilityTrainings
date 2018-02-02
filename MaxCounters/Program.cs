using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 4, 4, 6, 1, 4, 4 };
            int n = 5;
            Console.WriteLine("{0} => {1}", arrToString(a), arrToString(solution(n, a)));
            Console.Read();
        }

        public static string arrToString(int[] a)
        {
            return "[" + string.Join(",", a.Select(x => x.ToString()).ToArray()) + "]";
        }
        public static int[] solution(int N, int[] A)
        {
            int max = 0, baseMax = 0;
            int[] counters = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > N)
                {
                    baseMax = max;
                }
                else
                {
                    counters[A[i] - 1] = Math.Max(counters[A[i] - 1], baseMax);
                    counters[A[i] - 1]++;
                    if (counters[A[i] - 1] > max)
                    {
                        max = counters[A[i] - 1];
                    }
                }
            }
            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] = Math.Max(counters[i], baseMax);
            }

            return counters;
        }        
    }
}
