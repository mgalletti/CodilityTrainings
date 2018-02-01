using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 1, 2, 4, 3 };
            Console.WriteLine("solution for array [{0}] is {1}", arrToString(a), solution(a));
            Console.Read();
        }

        public static string arrToString(int[] a)
        {
            return string.Join(",", a.Select(x => x.ToString()).ToArray());
        }

        public static int solution(int[] A)
        {
            var diffs = new List<int>();
            int sum = A.Sum();
            int left = 0;
            for (int i = 0; i < A.Length; i++)
            {
                
                left += A[i];
                diffs.Add(Math.Abs((sum - left) - left));
            }
            return diffs.Min();
        }
    }
}
