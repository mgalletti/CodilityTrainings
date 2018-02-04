using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibFrog
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0 };
            Console.WriteLine("minimum jumps: {0}", solution(a));
            Console.Read();
        }

        public static int solution(int[] A)
        {
            int[] fn = Fib(A.Length);
            Array.Reverse(fn);

            var jumps = new List<Jump>();
            bool[] accessed = new bool[A.Length];
            int step = 0;

            jumps.Add(new Jump(-1, 0));
            Jump j = null;

            while (true)
            {
                if (step == jumps.Count)
                {
                    return -1;
                }
                j = jumps[step];
                step++;
                foreach (var n in fn)
                {
                    if (j.Position + n == A.Length)
                        return ++j.Counter;
                    else if (j.Position + n > A.Length || A[j.Position + n] == 0 || accessed[j.Position + n])
                        continue;

                    jumps.Add(new Jump(j.Position + n, j.Counter + 1));
                    accessed[j.Position + n] = true;
                    break;
                }
            }
        }

        static int[] Fib(int N)
        {
            int[] F = new int[N];
            F[1] = 1;
            int i = 2;
            do
            {
                F[i] = F[i - 2] + F[i - 1];
                i++;
            } while (F[i - 1] <= N);
            Array.Resize<int>(ref F, i);
            return F;
        }
        class Jump
        {
            public int Position { get; set; }
            public int Counter { get; set; }

            public Jump(int position, int counter)
            {
                this.Position = position;
                this.Counter = counter;
            }
        }

    }
}
