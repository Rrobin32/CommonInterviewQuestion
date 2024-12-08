using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
     * 1. Write a c sharp function with two strings as input and and frame the out put as
     * first letter from string 1 first letter from string 2 second letter from string1 second letter from string 2 until the end of each string is reached.
     * e.g Strin 1 ='Mountain' String 2= 'River' then console.output should print mroiuvnetrain
     */
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string input1 = "river";
            string input2 = "river";

            string result = await MergeStrings(input1.ToLower(), input2.ToLower());

            Console.WriteLine(result);
        }

        private static async Task<string> MergeStrings(string input1, string input2)
        {
            return await Task.Run(() =>
            {
                string result = string.Empty;

                if (input1.Length >= input2.Length)
                {
                    for(int i = 0; i <= input2.Length-1; i++)
                    {
                        result += input1[i].ToString() + input2[i].ToString();
                    }
                    result += input1.Substring(input2.Length);
                }
                else
                {
                    for (int i = 0; i <= input1.Length - 1; i++)
                    {
                        result += input1[i].ToString() + input2[i].ToString();
                    }
                    result += input2.Substring(input1.Length);
                }
                return result;
            });
        }
    }
}



