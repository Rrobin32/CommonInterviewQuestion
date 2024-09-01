using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /*
     * How to count the occurrence of each character in a string?
     */
    internal class CharOccurance
    {
        public static void Main(string[] args)
        {
            string inputString = "hello world";

            Dictionary<char, int> getOccurance = GetOccurance(inputString);

            foreach(var keyvalue in getOccurance)
            {
                Console.WriteLine("Char: " +  keyvalue.Key + ", Count: " + keyvalue.Value);
            }
        }

        public static Dictionary<char, int> GetOccurance(string inputString)
        {
            inputString = inputString.ToLower().Replace(" ", "");
            Dictionary<char, int> charOccurance = new Dictionary<char, int>();
            foreach (char c in inputString)
            {
                if (charOccurance.ContainsKey(c))
                {
                    charOccurance[c]++;
                }
                else
                {
                    charOccurance.Add(c, 1);
                }
            }
            return charOccurance;
        }
    }
}
