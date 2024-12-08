using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program01
    {
        public static void Main(string[] args)
        {
            string input = "IIII am am am aaa good good good developer developer";

            string result = string.Empty;

            string[] inputArray = input.Split(' ');
            foreach (string str in inputArray)
            {
                if (!result.Contains(str))
                {
                    bool checkDuplicate = IsDuplicated(str);
                    if (checkDuplicate)
                    {
                        result += str[0] + " ";
                    }
                    else
                    {
                        result += str + " ";
                    }
                }
            }

            Console.WriteLine(result);
        }

        public static bool IsDuplicated(string str)
        {
            bool isDuplicate = false;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char ch in str)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch]++;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }

            if (dict.Keys.Count == 1)
            {
                isDuplicate = true;
            }
            return isDuplicate;
        }
    }
}