using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_travel
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<int> ts = new List<int> { 50 };
            int? n = chooseBestSum(163, 3, ts);

            ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            n = chooseBestSum(230, 3, ts);
        }

        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            int? result = null;
            if (ls.Count < k) return result;

            var first = ls.Select(x => x);

            for (int i = 0; i < k-1; i++)
            {
                List<int> cp = new List<int>();
               // ls.CopyTo(cp.ToList();
                first = first.SelectMany(x => ls, (x, y) => x + y);
            }
            foreach (var item in first)
            {
                Console.WriteLine(item);
            }

            result = first.Where(x => x <= t).OrderByDescending(x => x).First();
            return result;

        }
   
    
    }
}
