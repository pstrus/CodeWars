using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scramblies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Scramble("rkqodlw", "world"));
         
            Console.ReadKey();
        }
        public static bool Scramble(string str1, string str2)
        {
            var str2Chars = str2.ToCharArray().ToList() ;
            foreach (var item in str1)
            {
                if (str2Chars.Contains(item))
                {
                    str2Chars.Remove(item);
                    if (str2Chars.Count == 0) return true;
                        }
                
            }
            return false;
        }

        public static int test(int input)
        {
            int t, y, u, v, x;
            y = input;
            t = y + 1;
            u = t ^ y;
            v = t & y;
            x = v - (v & -v) / (u + 1);

            return x;
        }

    }
}
