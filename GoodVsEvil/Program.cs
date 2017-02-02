using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodVsEvil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1"));
            Console.ReadKey();
        }

        public static string GoodVsEvil(string good, string evil)
        {
            int[] goodPoints = { 1, 2, 3, 4, 4, 10 };
            int[] evilPoints = { 1, 2, 2, 2, 3, 5, 10 };

            int GoodScore = good.Split(' ').Zip(goodPoints, (x, y) => int.Parse(x) * y).Sum();
            int EvilScore = evil.Split(' ').Zip(evilPoints, (x, y) => int.Parse(x) * y).Sum();

            return GoodScore > EvilScore ? "Battle Result: Good triumphs over Evil" : GoodScore == EvilScore ? "Battle Result: No victor on this battle field" : "Battle Result: Evil eradicates all trace of Good";
        }
    }
}
