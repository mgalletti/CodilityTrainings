using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAvgTwoSlice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 2, 2, 5, 1, 5, 8 };
            Console.WriteLine("{0} min avg slice position: {1}", arrToString(a), solution(a));
            Console.Read();
        }

        public static string arrToString(int[] a)
        {
            return "[" + string.Join(",", a.Select(x => x.ToString()).ToArray()) + "]";
        }

        public static int solution(int[] A)
        {
            bool goe3 = A.Length >= 3;
            double min_avg = (A[0] + A[1]) / 2.0;
            double part_avg = 0;
            int min_pos = 0;
            for (int i = 1; i < A.Length - 2; i++)
            {
                part_avg = (A[i] + A[i + 1]) / 2.0;
                if (part_avg < min_avg)
                {
                    min_avg = part_avg;
                    min_pos = i;
                }
                if (goe3)
                {
                    part_avg = (A[i] + A[i + 1] + A[i + 2]) / 3.0;
                    if (part_avg < min_avg)
                    {
                        min_avg = part_avg;
                        min_pos = i;
                    }
                }
            }
            part_avg = (A[A.Length - 2] + A[A.Length - 1]) / 2.0;
            if (part_avg < min_avg)
            {
                min_pos = A.Length - 2;
            }
            return min_pos;
        }
    }
}
