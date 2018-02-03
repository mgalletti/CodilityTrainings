using System;
using System.Collections.Generic;
using System.Linq;
using MiscUtils;

namespace StoneWall
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wall = { 8, 8, 5, 7, 9, 8, 7, 4, 8 };
            Console.WriteLine("{0} number of blocks: {1}", ArrayUtils.ToString(wall), solution(wall));
            Console.Read();
        }

        public static int solution(int[] H)
        {
            var s = new Stack<int>();
            s.Push(0);
            int blocks = 0;
            for (int i = 0; i < H.Length; i++)
            {
                
                while (H[i] < s.Peek())
                {
                    s.Pop();
                    blocks++;
                }
                if (H[i] == s.Peek())
                    continue;
                s.Push(H[i]);
            }
            while (s.Count>1)
            {
                s.Pop();
                blocks++;
            }
            return blocks;
        }
    }
}
