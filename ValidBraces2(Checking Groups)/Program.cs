using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidBraces2_Checking_Groups_
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool Check(string input)
        {
            Stack < char > stack = new Stack<char>();
            foreach (var item in input)
            {
                switch (item)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(item);
                        break;
                    case ')':
                        if (stack.Pop() != '(' || stack.Count == 0) return false;
                        break;
                    case ']':
                        if (stack.Pop() != '[' || stack.Count == 0) return false;
                        break;
                    case '}':
                        if (stack.Pop() != '{' || stack.Count == 0) return false;
                        break;
                }
                
            }
            return true;
        }
    }
}
