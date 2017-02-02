using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidBraces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(validBraces("())({}}{()][]["));
            Console.WriteLine(validBraces("(}"));
            Console.WriteLine(validBraces("[(])"));
            Console.WriteLine(validBraces("([{}])"));
            Console.ReadKey();
        }

        public static bool validBraces(String braces)
        {
            string leftBraces = "([{";
            string rightBraces = ")]}";
            string brace = braces;
            while (brace.Length>0)
            {
                string temp = string.Empty;
                for (int i = 0; i < brace.Length; i++)
                {
                    if (rightBraces.Contains(brace[i].ToString()))
                    {
                        int index = rightBraces.IndexOf(brace[i]);
                        
                        if (temp.Length==0 || temp[Math.Max(0, temp.Length - 1)] != leftBraces[index]) return false;
                        temp = temp.Remove(temp.Length - 1);
                    }
                    else temp += brace[i];           

                }
                brace = temp;
            }
            return true;
        }

        //nice method taken from CW
        public static bool validBraces2(string braces)
        {
            var st = new Stack<char>();
            foreach (var c in braces)
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        st.Push(c);
                        continue;
                    case ')':
                        if (st.Count == 0 || st.Pop() != '(') return false;
                        continue;
                    case ']':
                        if (st.Count == 0 || st.Pop() != '[') return false;
                        continue;
                    case '}':
                        if (st.Count == 0 || st.Pop() != '{') return false;
                        continue;
                }

            //DateTime.Today - D
            return st.Count == 0;
        }
    }
}
