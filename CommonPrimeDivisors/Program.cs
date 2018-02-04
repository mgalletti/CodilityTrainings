using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonPrimeDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 15, 10, 3 };
            int[] b = { 75, 30, 5 };
            Console.WriteLine("number of indexes: {0}", solution(a, b));
            Console.Read();
        }

        public static int solution(int[] A, int[] B)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int gcd_ab = gcd(A[i], B[i]);
                if (Check(A[i], gcd_ab) && Check(B[i], gcd_ab))
                {
                    count++;
                }
            }
            return count;
        }

        public static int gcd(int a, int b)
        {
            if (a % b == 0)
                return b;
            else
                return gcd(b, a % b);
        }

        public static bool Check(int a, int gcd_ab)
        {
            int rest = a / gcd_ab;
            while (gcd_ab % rest != 0)
            {
                int gcd_tmp = gcd(gcd_ab, rest);
                if (gcd_tmp == 1)
                {
                    return false;
                }
                rest /= gcd_tmp;
            }
            return true;
        }
    }
}
