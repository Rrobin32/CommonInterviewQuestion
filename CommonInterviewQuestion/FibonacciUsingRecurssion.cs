using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class FibonacciUsingRecurssion
    {
        public static void FibonacciRecursive
       (
        int firstnumber,
        int secondnumber,
        int counter,
        int length
       )
        {
           if(counter <= length)
            {
                Console.WriteLine(firstnumber);
                FibonacciRecursive(secondnumber, firstnumber + secondnumber, counter + 1, length);
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());
            FibonacciRecursive(0, 1, 1, length);
            Console.ReadKey();
        }
    }
}
