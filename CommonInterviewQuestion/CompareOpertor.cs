using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    class CompareOpertor
    {
        public static void Main(string[] args)
        {
            string str1 = new string("Upasana");
            string str2 = new string("Upasana");
            if (str1.Equals(str2))
            {
                Console.WriteLine("Equals Operator : returns true " + str1 + " " + str2);
            }
            else
            {
                Console.WriteLine("Equals Operator : returns false " + str1 + " " + str2);
            }
            if (str1 == str2)
            {
                Console.WriteLine(" == Operator : return true " + str1 + " " + str2);
            }
            else
            {
                Console.WriteLine(" == Operator : return false " + str1 + " " + str2);
            }
            Console.ReadLine();
        }
    }
}
