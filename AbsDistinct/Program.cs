using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsDistinct
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int solution(int[] A)
        {
            int l = 0;
            int r = A.Length-1;

            int count = 0;

            while (l <= r)
            {
                int absl = Math.Abs(A[l]);
                int absr = Math.Abs(A[r]);

                count++;
                if (absl < absr)
                {
                    while (r > 0 && absr == Math.Abs(A[r]))
                    {
                        r--;
                    }
                }
                else if (absl > absr)
                {
                    while (l <= A.Length - 1 && absl == Math.Abs(A[l]))
                    {
                        l++;
                    }
                }
                else
                {
                    while (r > 0 && absr == Math.Abs(A[r]))
                    {
                        r--;
                    }
                    while (l <= A.Length - 1 && absl == Math.Abs(A[l]))
                    {
                        l++;
                    }
                }
            }
            return count;
        }
    }
}
