using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sides_Of_An_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 })); //3
            Console.WriteLine(FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 })); //1
            Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 })); //-1
            Console.WriteLine(FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));//3
            Console.ReadKey();
        }

        public static int FindEvenIndex(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int Left = arr.Take(i).Sum();
                int Right = arr.Skip(i + 1).Sum();
                if (Left == Right) return i;

            }
            return -1;
            //long[] a;
            //a.OrderBy(s=>s).First();
            //Array.ConvertAll<char,long>(a.ToString().Reverse().ToArray(), s => long.Parse(s.ToString()));
        }
    }
}
