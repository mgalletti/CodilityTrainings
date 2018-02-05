using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAbsSumOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int solution(int[] A)
        {
            Array.Sort(A);
            int l = 0;
            int r = A.Length - 1;
            int min = Math.Abs(A[0]*2);

            while (l <= r)
            {
                int lsum = Math.Abs(A[l] * 2);
                int rsum = Math.Abs(A[r] * 2);
                int sum = Math.Abs(A[l] + A[r]);
                if (lsum < min)
                {
                    min = lsum;
                }
                if (rsum < min)
                {
                    min = rsum;
                }
                if (sum < min)
                {
                    min = sum;
                }

                if (A[l] >= 0)
                {
                    break;
                }

                if (lsum < rsum)
                {
                    r--;
                }
                else if (lsum > rsum)
                { 
                    l++;
                }
                else
                {
                    l++;
                    r--;
                }

            }
            return min;
        }
    }
}
