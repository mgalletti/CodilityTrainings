using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int 
                a = 0, 
                b = 0, 
                k = 11;
            Console.WriteLine("[{0} .. {1}] numbers divisible for {2}: {3}", a, b, k, solution(a, b, k));
            Console.Read();
        }
        public static int solution(int A, int B, int K)
        {
            if (K == 1)
            {
                return B - A + 1;
            }
            if (B == 0)
            {
                return 1;
            }
            if (K > B)
            {
                return 0;
            }
            int res = Convert.ToInt32(B / K) - Convert.ToInt32(A / K);
            if (A % K == 0 || A == 0)
            {
                res++;
            }
            return res;
        }
    }
}
