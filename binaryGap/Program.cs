using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 529, 20, 15 };
            foreach (var n in numbers)
            {
                Console.WriteLine(string.Format("max bin gap in {0} is {1}", n, solution(n)));
            }
            Console.Read();
        }

        public static int solution(int N)
        {
            int longest = 0;
            int gapSize = 0;
            bool trail0 = false;
            while (N > 0)
            {
                if ((N & 1) == 1)
                {
                    if (gapSize > longest)
                    {
                        longest = gapSize;
                    }
                    gapSize = 0;
                    trail0 = true;
                }
                else if (trail0)
                {
                    gapSize++;
                }

                N = N >> 1;
            }
            return longest;
        }
    }
}
