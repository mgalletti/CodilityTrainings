using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiscUtils;

namespace Peaks
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
            int[] a = { 0, 1, 0, 0, 1, 0, 0, 1, 0 };
            Console.WriteLine("{0} max number of blocks with peak: {1}", ArrayUtils.ToString(a), solution(a));
            Console.Read();
        }

        public static int solution(int[] A)
        {
            int N = A.Length;
            int size = N;
            int k = 1;
            
            while (k * k < N)
            {
                if (N % k == 0)
                {
                    if (BlocksHavePeaks(A, k))
                        size = Math.Min(size, k);
                    if (BlocksHavePeaks(A, N / k))
                        size = Math.Min(size, N / k);
                }
                k++;
            }
            if (k*k == N  && BlocksHavePeaks(A, k))
                    size = Math.Min(size, k);
            if (size == N && !peaksFound)
                return 0;
            else
                return N / size;
        }
        public static bool peaksFound = false;
        public static bool BlocksHavePeaks(int[] A, int size)
        {
            int s = 0, e = size - 1, count = A.Length / size;
            bool found = true;
            for (int i = 1; i <= count; i++)
            {
                bool peak = false;
                for (int j = s; j <= e; j++)
                {
                    if (j-1 < 0 || j+1 >= A.Length)
                        continue;
                    if (A[j-1] < A[j] && A[j] > A[j + 1])
                    {
                        peak = true;
                    }
                }
                found = found && peak;
                s += size;
                e += size;
            }
            peaksFound = peaksFound || found;
            return found;
        }
    }
}
