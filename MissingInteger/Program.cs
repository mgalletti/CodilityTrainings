using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 6, 4, 1, 2 };
            Console.WriteLine("{0} first smallest number is: {1}", arrToString(a), solution(a));
            Console.Read();
        }
        public static string arrToString(int[] a)
        {
            return "[" + string.Join(",", a.Select(x => x.ToString()).ToArray()) + "]";
        }

        public static int solution(int[] A)
        {
            int max = A.Max();
            if (max <= 0)
            {
                return 1;
            }
            var numbers = new HashSet<int>(Enumerable.Range(1, max));
            foreach (var n in A)
            {
                if (n <= 0)
                {
                    continue;
                }
                if (numbers.Contains(n))
                    numbers.Remove(n);
            }
            if (numbers.Count == 0)
                return max + 1;
            else
                return numbers.First();
        }
    }

}
