using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreTheySame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            Console.WriteLine(comp(a, b));
            Console.ReadKey();
        }

        public static bool comp(int[] a, int[] b)
        {
            if (a == null && b == null) return true;
            else if (a == null) return false;
            else if (b == null) return false;
            else if (a.Length != b.Length) return false;

            foreach (var item in a)
            {
                if (!b.Contains((int) (Math.Pow(item, 2)))) return false;
            }
            return true;
        }
    }
}
