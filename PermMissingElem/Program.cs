using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 5 };
            Console.WriteLine("{0} missing number is: {1}", arrToString(a), solution(a));
            Console.Read();
        }

        public static string arrToString(int[] a)
        {
            return "[" + string.Join(",", a.Select(x => x.ToString()).ToArray()) + "]";
        }

        public static int solution(int[] A)
        {
            int tot = Enumerable.Range(1, A.Length + 1).Sum();
            return tot - A.Sum();
        }
    }
}
