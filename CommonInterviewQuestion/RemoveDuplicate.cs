using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /*
     * Remove Duplicate From String
     */
    internal class RemoveDuplicate
    {
        public static void Main(string[] args)
        {
            string inputString = "HHeelloo WWoorrlldd";
            Console.WriteLine(RemoveDuplicateFromString(inputString));
        }

        public static string RemoveDuplicateFromString(string inputString)
        {
            string result = string.Empty;
            foreach (char c in inputString)
            {
                if (!result.Contains(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
