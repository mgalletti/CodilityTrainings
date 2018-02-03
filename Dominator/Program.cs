using System;
using System.Collections.Generic;
using System.Linq;
using MiscUtils;

namespace Dominator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 8, 4, 6, 8, 6, 6, 8, 6, 6, 9 };
            Console.WriteLine("{0} index of leader is: {1}", ArrayUtils.ToString(a), solution(a));
            Console.Read();
        }
        public static int solution(int[] A)
        {
            var size = 0;
            var val = -1;
            foreach (var n in A)
            {
                if (size == 0)
                {
                    val = n;
                    size++;
                }
                else
                {
                    if (n != val)
                        size--;
                    else
                        size++;
                }
            }
            var candidate = -1;
            if (size > 0)
            {
                candidate = val;
            }
            int index = -1, count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                
                if (A[i] == candidate)
                {
                    count++;
                    index = i;
                }
            }
            if (count > A.Length / 2)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }
    }
}
