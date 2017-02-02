using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBits(1234));
            Console.ReadKey();
        }

        public static int CountBits(int n)
        {
            string i = Convert.ToString(n, 2);
            var x = i.Split(new[] { '0' }, StringSplitOptions.RemoveEmptyEntries);
            var b =  x.Select(a => a.Length);
            return b.Sum();

            //or easier
            int res = i.Count(a => a == '1');
        }
    }
}
