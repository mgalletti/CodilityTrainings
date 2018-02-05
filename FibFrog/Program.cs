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
            //int[] a = { 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0 };
            int[] a = { 0, 0, 0, 0 };
            Console.WriteLine("minimum jumps: {0}", solution(a));
            Console.Read();
        }

        // solution 2
        public static int solution(int[] A)
        {
            int FLength = 26;
            int[] F = new int[FLength];
            int[] reacheable = new int[A.Length];
            F[0] = 0;
            F[1] = 1;
            int i = 2;
            while (i < FLength)
            {
                F[i] = F[i - 1] + F[i - 2];
                if (F[i] - 1 == A.Length)
                {
                    return 1;
                }
                if (F[i] - 1 < reacheable.Length && A[F[i] - 1] == 1)
                    reacheable[F[i] - 1] = 1;

                i++;
            }

            int min_jumps = Int32.MaxValue;
            for (i = 0; i < A.Length; i++)
            {
                if (reacheable[i] == 0)
                    continue;

                int min_from_here = reacheable[i];

                for (int j = 2; j < F.Length; j++)
                {
                    int next_pos = i + F[j];
                    if (next_pos == A.Length)
                    {
                        if (min_from_here + 1 < min_jumps)
                        {
                            min_jumps = min_from_here + 1;
                        }
                        break;
                    }

                    if (next_pos > A.Length || A[next_pos] == 0)
                    {
                        continue;
                    }

                    if (reacheable[next_pos] == 0 || reacheable[next_pos] > min_from_here + 1)
                    {
                        reacheable[next_pos] = min_from_here + 1;
                    }
                }
            }

            return min_jumps == Int32.MaxValue ? -1 : min_jumps;
        }

        // solution 1
        /* 
        public static int solution(int[] A)
        {
            F = Fib(26);
            Check(A, -1, A.Length, 0);
            if (total_jumps == Int32.MaxValue)
                return -1;
            else
                return total_jumps;
        }

        public static void Check(int[] A, int pos, int N, int count)
        {
            count++;
            if (count >= total_jumps)
            {
                return;
            }
            int i = F.Length - 1;
            int f;
            while (i > 1)
            {
                f = F[i];
                if (pos + f == N)
                {
                    total_jumps = count;
                    return;
                }
                else if (pos + f < N)
                {
                    break;
                }
                i--;
            }
            while (i > 1)
            {
                f = F[i];
                if (A[pos + f] == 1)
                {
                    Check(A, pos + f, N, count);
                }
                i--;
            }
        }

        public static int total_jumps = Int32.MaxValue;

        public static int[] F;

        public static int[] Fib(int N)
        {
            int[] res = new int[N];
            res[1] = 1;
            int i = 2;
            while (i < N)
            {
                res[i] = res[i - 1] + res[i - 2];
                i++;
            } 
            return res;
        }        
        */
    }
}
