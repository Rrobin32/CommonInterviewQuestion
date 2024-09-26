using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class AsyncAwaitSecondlargestElement
    {
        static async Task Main(string[] args)
        {
            int[] array = { 2, 11, 15, 1, 7, 99, 6, 85, 4 };
            int secondHighest = await FindSecondHighestAsync(array);
            Console.WriteLine($"Second Highest Value In Array: {secondHighest}");

            Console.WriteLine();
            Console.WriteLine("****************************");
            var result = await FindTopTwoElement(array);
            Console.WriteLine($"Highest Value In Array: {result.highest}");
            Console.WriteLine($"Second Highest Value In Array: {result.secondHighest}");
        }

        static async Task<int> FindSecondHighestAsync(int[] array)
        {
            int max = await Task.Run(() => array.Max());
            int secondHighest = await Task.Run(() => array.Where(x => x != max).Max());
            return secondHighest;
        }

        static async Task<(int highest, int secondHighest)> FindTopTwoHighestAsync(int[] array)
        {
            int highest = await Task.Run(() => array.Max());
            int secondHighest = await Task.Run(() => array.Where(x => x != highest).Max());
            return (highest, secondHighest);
        }

        static async Task<(int highest, int secondHighest)> FindTopTwoHighestAsyncWithoutLINQ(int[] array)
        {
            return await Task.Run(() =>
            {
                int highest = int.MinValue;
                int secondHighest = int.MinValue;

                foreach (int number in array)
                {
                    if (number > highest)
                    {
                        secondHighest = highest;
                        highest = number;
                    }
                    else if (number > secondHighest && number != highest)
                    {
                        secondHighest = number;
                    }
                }

                return (highest, secondHighest);
            });
        }

        static async Task<(int highest, int secondHighest)> FindTopTwoElement(int[] array)
        {
            return await Task.Run(() =>
            {
                int highest = int.MinValue;
                int secondHighest = int.MinValue;

                foreach (var i in array)
                {
                    if (i > highest)
                    {
                        secondHighest = highest;
                        highest = i;
                    }
                    else if (i > secondHighest && i != highest)
                    {
                        secondHighest = i;
                    }
                }
                return (highest, secondHighest);
            });
        }

        static async Task<(int highest, int secondHighest)> FindTopTwoElementUsingLINQ(int[] array)
        {
            int highest = await Task.Run(() => array.Max());
            int secondHighest = await Task.Run(() => array.Where(x => x != highest).Max());
            return (highest, secondHighest);
        }
    }
}

