using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 3, 1, 2 };
            Console.WriteLine("{0} permutation check result: {1}", arrToString(a), solution(a));
            a = new int[]{ 4, 3, 1 };
            Console.WriteLine("{0} permutation check result: {1}", arrToString(a), solution(a));
            Console.Read();
        }
        public static string arrToString(int[] a)
        {
            return "[" + string.Join(",", a.Select(x => x.ToString()).ToArray()) + "]";
        }

        public static int solution(int[] A)
        {
            var numbers = new HashSet<int>();
            foreach (var n in A)
            {
                if (numbers.Contains(n) || n > A.Length)
                {
                    return 0;
                }
                numbers.Add(n);
            }
            return 1;
            }
        }
}
