using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class MoveLastLetter
    {
        //Move the first letter of each word to the end of it, then add 'ay' to the end of the word.
        //Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
        public static string PigIt(string str)
        {
            var split = str.Split(' ');
            string FinalString = String.Empty;
            foreach (var item in split)
            {
                string temp = string.Empty;
                for (int i = 1; i < item.Length; i++)
                {
                    temp += item[i];

                }
                temp += item[0];
                temp += "ay ";
                FinalString += temp;
            }

            return FinalString.Trim(); ;
        }

        public static string PigItOneLine(string str)
        {
            return string.Join(" ", str.Split().Select(x => x.Substring(1) + x[0] + "ay"));
        }

    }
}
