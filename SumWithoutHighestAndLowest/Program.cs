using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumWithoutHighestAndLowest
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2) return 0;
            return numbers.Sum() - numbers.Min() - numbers.Max();
        }
    }
}
