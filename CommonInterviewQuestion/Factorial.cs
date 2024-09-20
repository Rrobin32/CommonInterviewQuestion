using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class Factorial
    {
        public static void Main(string[] args)
        {
            int input = 4;
            int result = findFactorial(input);

            Console.WriteLine(result);  
        }

        public static int findFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * findFactorial(number - 1);
        }
    }
}
