using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscUtils
{
    public class ArrayUtils
    {
        public static string ToString(int[] a)
        {
            return "[" + string.Join(",", a.Select(x => x.ToString()).ToArray()) + "]";
        }
    }
}
