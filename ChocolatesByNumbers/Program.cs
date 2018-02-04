using System;
using System.Collections.Generic;

namespace ChocolatesByNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int
                n = 10,
                m = 4;
            Console.WriteLine("{0} chocos, in {1} steps you eat: {2}", n, m, solution(n, m));
            Console.Read();
        }

        public static int solution(int N, int M)
        {
            int d = gcd(N, M);
            return N / d;
        }

        public static int gcd(int a, int b)
        {
            if (a % b == 0)
                return b;
            else
                return gcd(b, a % b);
        }
    }
}
