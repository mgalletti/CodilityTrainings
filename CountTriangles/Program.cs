using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 2, 5, 1, 8, 12 };
            
            Console.WriteLine("number of triangles: {0}", solution(a));
            Console.Read();
        }

        public static int solution(int[] A)
        {
            if (A.Length < 3)
                return 0;

            Array.Sort(A);
            int count = 0;
            for (int p = 0; p < A.Length - 2; p++)
            {
                int q = p + 1;
                int r = p + 2;
                while (r < A.Length)
                {
                    if (A[p] + A[q] > A[r])
                    {
                        count += r - q;
                        r++;
                    }
                    else
                    {
                        q++;
                        if (r == q)
                        {
                            r++;
                        }
                    }
                }
            }
            return count;
        }
        
    }
}
