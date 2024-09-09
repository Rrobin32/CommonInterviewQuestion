using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    public class LargestWordFromString
    {
        public static void Main(string[] args)
        {
            string str = "Hardships often prepare ordinary people for an extraordinary destiny";
            string[] strArray = str.Split(" ");
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            foreach (var item in strArray)
            {
                keyValuePairs.Add(item, item.Length);
            }
            string largest = keyValuePairs.OrderByDescending(p => p.Value).Select(p => p.Key).First();
            string smallest = keyValuePairs.OrderByDescending(p => p.Value).Select(p => p.Key).Last();
            Console.WriteLine(smallest + "   " + largest);
        }
    }
}
