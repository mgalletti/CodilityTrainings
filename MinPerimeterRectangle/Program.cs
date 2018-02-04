using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPerimeterRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 30;
            Console.WriteLine("{0} minimal perimeter is: {1}", n, solution(n));
            Console.ReadLine();
        }
        public static int solution(int N)
        {
            int perimeter = Int32.MaxValue;
            int i = 1;
            while (i * i < N)
            {
                if (N % i == 0)
                {
                    perimeter = Math.Min(perimeter, 2 * (i + N / i));
                }
                i++;
            }
            if (i * i == N)
            {
                perimeter = Math.Min(perimeter, 2 * (i + N / i));
            }
            return perimeter;
        }
    }
}
