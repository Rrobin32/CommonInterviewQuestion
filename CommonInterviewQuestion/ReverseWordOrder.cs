using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /*
     * reverse the order of words in a given string?
     * input: Welcome to Csharp corner, output: corner Csharp to Welcome
     */
    internal class ReverseWordOrder
    {
        public static void Main(string[] args)
        {
            string input = "Welcome to Csharp corner";
            Console.WriteLine(reverseWord(input));
        }

        public static string reverseWord(string word)
        {
            StringBuilder output = new StringBuilder();
            string[] array = word.Split(' ');
            for(int i = array.Length - 1; i > -1; i--)
            {
                output.Append(array[i]);
                output.Append(" ");
            }
            
            return output.ToString();
        }
    }
}
