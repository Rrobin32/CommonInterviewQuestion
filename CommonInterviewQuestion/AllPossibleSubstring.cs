using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /*
     * Find all possible substring of a given string
     */
    internal class AllPossibleSubstring
    {
        public static void Main(string[] args)
        {
            string inputString = "abcd";

            GenerateSubstring(inputString);
        }

        public static void GenerateSubstring(string inputString)
        {           
            for (int i = 0; i <= inputString.Length; i++)
            {
                StringBuilder substring = new StringBuilder(inputString.Length - i);
                for (int j = i; j < inputString.Length; j++)
                {
                    substring.Append(inputString[j]);
                    Console.Write(substring + " ");
                }
            }
        }
    }
}
