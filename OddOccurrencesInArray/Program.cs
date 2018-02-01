using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 3, 9, 3, 9, 7, 9 };
            Console.WriteLine("Odd number is: " + solution(arr));
            Console.Read();
        }
        public static int solution(int[] A)
        {
            var counter = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (counter.ContainsKey(A[i]))
                    counter.Remove(A[i]);
                else
                    counter.Add(A[i], 1);
            }
            return counter.First().Key;
        }
    }
}
