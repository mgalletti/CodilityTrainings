using System;
using System.Collections.Generic;
using System.Linq;
using MiscUtils;

namespace Leader
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {6, 8, 4, 6, 8, 6, 6 };
            Console.WriteLine("{0} leader value is: {1}",ArrayUtils.ToString(a), CalcLOn(a));
            Console.Read();
        }

        public static int CalcLOn(int[] A)
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
            var count = 0;
            foreach (var n in A)
            {
                if (n == candidate)
                {
                    count++;
                }
            }
            if (count > A.Length / 2)
            {
                return candidate;
            }
            else
            {
                return -1;
            }
        }
    }
}
