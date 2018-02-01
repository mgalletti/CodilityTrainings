using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestArrayNumber
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int solution(int[] A)
        {
            int small = 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (findN(A, small))
                {
                    small++;
                }

            }
            return small;
        }
        
        public static bool findN(int[] a, int val)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == val)
                {
                    return true;
                }
            return false;
        }
    }
}
