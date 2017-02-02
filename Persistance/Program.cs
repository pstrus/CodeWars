using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Persistence(4));
            Console.ReadKey();
        }

        public static int Persistence(long n)
        {
            int result = 0;
            while (n.ToString().Length>1)
            {
                string no = n.ToString();
                n = 1;
                foreach (var item in no)
                {
                    n = n * int.Parse(item.ToString());
                }
                result++;

            }

            return result;

        }
    }
}
