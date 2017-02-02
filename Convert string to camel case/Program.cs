using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_string_to_camel_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("the-stealth-warrior"));


            Console.WriteLine(ToCamelCase("The_Stealth_Warrior"));
            Console.ReadKey();

        }

        public static string ToCamelCase(string str)
        {
            string result = str[0].ToString();
            bool isFirstUpper = char.IsUpper(str[0]);
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == '_' || str[i] == '-')
                {
                    i++;
                    result += str[i].ToString().ToUpper();
                }
                else result += str[i];
                
                //if (char.IsUpper(str[i]) && isFirstUpper) result += "_" + str[i];
                //else if (char.IsUpper(str[i]) && !isFirstUpper) result += "-" + str[i];
                //else result += str[i];
            }
            return result;


         }
    }
}
