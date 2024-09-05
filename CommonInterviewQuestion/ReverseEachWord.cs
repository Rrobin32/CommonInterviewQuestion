using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /*
     * reverse each word in a given string
     * RAKESH KUMAR => HSEKAR RAMUK
     */
    internal class ReverseEachWord
    {
        public static void Main(string[] args)
        {
            string input = "RAKESH KUMAR";
            Console.WriteLine(reverseEachString(input));
        }

        public static string reverseEachString(string input)
        {
            StringBuilder output = new StringBuilder();
            string[] strings = input.Split(' ');

            for(int i = 0; i <= strings.Length - 1; i++)
            {
                for (int j = strings[i].Length - 1; j > -1; j--)
                {
                    output.Append(strings[i][j]);
                }
                output.Append(' ');
            }
            return output.ToString();
        }
    }
}
