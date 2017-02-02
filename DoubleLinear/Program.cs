using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DblLinear(10));
            Console.ReadKey();
        }

        public static int DblLinear(int n)
        {
            var h = new int[++n];
            int x2 = 1, x3 = 1;
            int i = 0, j = 0;
            for (int index = 0; index < n; index++)
            {
                h[index] = x2 < x3 ? x2 : x3;
                if (h[index] == x2) x2 = 2 * h[i++] + 1;
                if (h[index] == x3) x3 = 3 * h[j++] + 1;
            }
            return h[--n];
        }
    }
}
