using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitStringsIntoPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("abc")); // should return ["ab", "c_"]
            Console.WriteLine(Solution("abcdef"));
            Console.ReadKey();
        }

        public static string[] Solution(string str)
        {
            if (str.Length % 2 == 1) str += '_';
            var splitted = Enumerable.Range(0, str.Length);
            var splitted2 = splitted.GroupBy(x => x / 2);
            var splitted3 = splitted2.Select(x => new string(x.Select(y => str[y]).ToArray()));

            // or in one
            return splitted.GroupBy(x => x / 2).Select(x => new string(x.Select(y => str[y]).ToArray())).ToArray();

            //return splitted3.ToArray();
                                     
        }
    }
}
