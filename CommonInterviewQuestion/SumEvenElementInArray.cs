using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /*
     * Given an array of ints, write a C# method to total all the values that are even numbers.
     */
    internal class SumEvenElementInArray
    {
        public static async Task Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, };
            int result = await CalculateSum(array);
            Console.WriteLine(result);
        }

        public static async Task<int> CalculateSum(int[] array)
        {
            int sum = await Task.Run(() => array.Where(p => p%2 == 0).Sum());
            return sum;
        }
    }
}
