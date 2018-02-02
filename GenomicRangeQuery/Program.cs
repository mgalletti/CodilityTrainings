using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenomicRangeQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p = { 2, 5, 0 }, q = { 4, 5, 6 };
            string dna = "CAGCCTA";
            Console.WriteLine(arrToString(solution(dna, p, q)));
            Console.Read();
        }

        public static string arrToString(int[] a)
        {
            return "[" + string.Join(",", a.Select(x => x.ToString()).ToArray()) + "]";
        }

        public static int[] solution(string S, int[] P, int[] Q)
        {
            int[] res = new int[P.Length];

            int[][] gen = new int[3][] {
                new int[S.Length+1],
                new int[S.Length+1],
                new int[S.Length+1]
            };

            int a, c, g;
            for (int i = 0; i < S.Length; i++)
            {
                a = 0;
                c = 0;
                g = 0;
                if (S[i] == 'A')
                {
                    a = 1;
                }
                else if (S[i] == 'C')
                {
                    c = 1;
                }
                else if (S[i] == 'G')
                {
                    g = 1;
                }
                gen[0][i + 1] = gen[0][i] + a;
                gen[1][i + 1] = gen[1][i] + c;
                gen[2][i + 1] = gen[2][i] + g;
            }

            for (int i = 0; i < P.Length; i++)
            {
                int sIx = P[i], eIx = Q[i] + 1;
                if (gen[0][eIx] - gen[0][sIx] > 0)
                {
                    res[i] = 1;
                }
                else if (gen[1][eIx] - gen[1][sIx] > 0)
                {
                    res[i] = 2;
                }
                else if (gen[2][eIx] - gen[2][sIx] > 0)
                {
                    res[i] = 3;
                }
                else
                    res[i] = 4;
            }
            return res;
        }
    }
}
