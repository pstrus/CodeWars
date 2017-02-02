using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseRacing_usingTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] time = Race(720, 850, 70);
            Console.WriteLine("{0}  {1}  {2}",time[0].ToString(), time[1].ToString(), time[2].ToString());
            Console.ReadKey();
        }
        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2) return null;

            double seconds = (double)g / (v2 - v1) * 3600;
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            return new int[] { t.Hours, t.Minutes, t.Seconds };
        }
    }
}
