using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /* 
     * Print Fibbonacci Series
     * 0, 1, 1, 2, 3, 5, 8, 13, 21
     */
    internal class Fibonacci
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(generateFibonacci(10));
        }
        static string generateFibonacci(int element)
        {
            int a = 0, b = 1, c;
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < element; i++)
            {
                sb.Append(a.ToString() + ",");
                c = a + b;
                a = b;
                b = c;
            }
            return sb.ToString().Remove(sb.Length - 1);
        }
    }

    
}
