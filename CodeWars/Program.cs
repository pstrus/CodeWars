using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {

            // string test = MoveLastLetter.PigIt("Pig latin is cool");
            //string test = MoveLastLetter.PigItOneLine("Pig latin is cool");
            //Console.WriteLine(test);
            //Console.ReadKey();

            //double[] array = Array.ConvertAll(stringArray, double.Parse);

            //Console.WriteLine(MiddleCharacter("testing"));

            Console.WriteLine(Extending("RqaEzty"));
            Console.WriteLine(Tribonacci(new double[] { 1, 1, 1}, 10));

            Console.ReadKey();


        }

        public static string MiddleCharacter(string s)
        {
            return s.Length % 2 == 0 ? s.Substring(s.Length / 2 - 1, 2) : s.Substring(s.Length / 2 , 1);
        }

        public static string Extending (string s)
        {
            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                result += char.ToUpper(s[i]);
                result += new string(char.ToLower(s[i]), i);
                if(i<s.Length-1)
                    result += "-";
            }
            return result;
        }


        public static double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
                return new double[0];
            List<double> results = new List<double>();
            results.Add(signature[0]);
            results.Add(signature[1]);
            results.Add(signature[2]);
            for (int i = 3; i < n; i++)
            {
                results.Add(results[i - 3] + results[i - 2] + results[i - 1]);


            }

            return results.Where((c, i) => i <= n).ToArray();

        }
  }

    }

