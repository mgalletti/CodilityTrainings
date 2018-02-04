using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 24;
            Console.WriteLine("{0} has {1} divisors", n, solution(n));
            Console.ReadLine();
        }

        public static int solution(int N)
        {
            int count = 0;
            int i = 1;
            while (i*i < N)
            {
                if (N % i == 0)
                {
                    count += 2;
                }
                i++;
            }
            if (i*i == N)
            {
                count++;
            }
            return count;
        }
    }
}
