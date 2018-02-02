using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 85, d = 30;
            Console.WriteLine("X: {0}, Y: {1}, D: {2} => steps needed: {3}", x, y, d, solution(x, y, d));
            Console.Read();
        }

        public static int solution(int X, int Y, int D)
        {
            int start = Y - X;
            if (start == 0)
            {
                return 0;
            }
            int steps = start / D;
            if (start % D > 0)
            {
                steps++;
            }
            return steps;
        }
    }
}
