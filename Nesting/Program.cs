using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //string S = "(()(())())";
            string S = "(()";
            Console.WriteLine("{0} is balanced: {1}", S, solution(S));
            Console.Read();
        }

        public static int solution(string S)
        {
            int brackets = 0;
            bool isOpen = false;
            foreach (var c in S)
            {
                if (c == ')')
                {
                    if(!isOpen)
                        return 0;
                    else
                    {
                        brackets--;
                        isOpen = brackets > 0;
                    }
                }
                else
                {
                    isOpen = true;
                    brackets++;
                }
            }
            if (isOpen)
                return 0;
            else
                return 1;
        }
    }
}
