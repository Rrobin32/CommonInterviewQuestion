using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    class ReverseString
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String that need to be reversed : ");
            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                chars[i] = str[j];//char[0] = char[1]  
                chars[j] = str[i];//char[1] = char[0]
            }
            string reversedString = new string(chars);
            Console.WriteLine(reversedString);

            //string str = @"VC3 of is firmly committed to the development of applications using Microsoft's .
            //               NET framework to develop cutting-edge solutions that take advantage of modern design paradigms.";

            //var result = Regex.Split(str.ToLower(), @"\W+").GroupBy(x => x.ToString()).Select(y => new { Count = y.Count(), Word = y.Key }).Where(z => z.Count > 1);

            //string[] splitString = str.Split(' ');


            //var arrayCount = splitString.GroupBy(a => a).Select(y => new { Count = y.Count(), Word = y.Key }).Where(z => z.Word != "").OrderByDescending(y => y.Count).ToList();
            //Console.WriteLine(arrayCount.First().Word);

            //foreach (var item in arrayCount)
            //{
            //    Console.WriteLine(item.Word, item.Count);
            //}

        }
    }
}
