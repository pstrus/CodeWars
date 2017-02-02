using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontGiveMeFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DontGiveMeFive(1, 9)); //8
            Console.WriteLine(DontGiveMeFive(4, 17)); //12
            Console.ReadKey();
        }

        public static int DontGiveMeFive(int start, int end)
        {
            return Enumerable.Range(start, end - start+1).Where(x => !x.ToString().Contains('5')).Count();
        }
    }
}
