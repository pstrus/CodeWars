using System.Linq;

namespace FirstNonRepeatingLetter
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string FirstNonRepeatingLetter(string s)
        {
            var ret = s.GroupBy(z => char.ToLower(z)).Where(g => g.Count() == 1).FirstOrDefault();
            return  ret.First().ToString() ?? string.Empty;
        }
    }
}
