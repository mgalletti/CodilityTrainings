using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushroomPicker
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int solution(int[] A, int k, int m)
        {
            int n = A.Length;
            int res = 0;
            int[] psums = PrefixSums(A);

        }

        public static int[] PrefixSums(int[] A)
        {
            int[] res = new int[A.Length + 1];            
            for (int i = 1; i < A.Length + 1; i++)
            {
                res[i] = res[i - 1] + A[i - 1];
            }
            return res;
        }
    }
}
