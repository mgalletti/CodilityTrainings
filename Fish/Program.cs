using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 3, 2, 1, 5 };
            int[] b = { 0, 1, 0, 0, 0 };
            //int[] b = { 1, 0, 1, 1, 1 };
            Console.WriteLine("fishes still alive: {0}", solution(a, b));
            Console.Read();
        }

        public static int solution(int[] A, int[] B)
        {
            var fishes = new Stack<int>();
            var direction = new Stack<int>();
            
            for (int i = 0; i < A.Length; i++)
            {
                while (fishes.Count > 0 && i < A.Length && direction.Peek() > B[i])
                {
                    if (fishes.Peek() > A[i])
                    {
                        i++;
                    }
                    else
                    {
                        fishes.Pop();
                        direction.Pop();
                    }
                }
                if (i < A.Length &&(fishes.Count == 0 || direction.Peek() <= B[i]))
                {
                    fishes.Push(A[i]);
                    direction.Push(B[i]);
                }
            }
            return fishes.Count;
        }
    }
}
