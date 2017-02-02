using System.Collections.Generic;
using System.Linq;

namespace Sum_by_Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            sumOfDivided(new int[] { 15, 30, -45 });
        }

        public static string sumOfDivided(int[] lst)
        {
            Dictionary<int, List<int>> resultDict = new Dictionary<int, List<int>>();
            foreach (var item in lst)
            {
                int temp = item<0?-item:item;
                for (int b = 2; temp > 1; b++)
                {
                    if (temp % b == 0)
                    {
                        while (temp % b == 0) temp /= b;
                        if (!resultDict.ContainsKey(b))
                            resultDict[b] = new List<int>() { item  };
                        else
                            resultDict[b].Add(item);
                    }
                }
            }

            string result = string.Empty;
            var res = resultDict.OrderBy(x => x.Key);
            foreach (var item in res) result += "(" + item.Key + " " + item.Value.Sum() + ")";
            return result;

        }

 
    }
}
