using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class SecondLargestElement
    {
        public static void Main(string[] args)
        {
            int[] arr = { 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            int largestElement = arr[0], secondLargestElement = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (largestElement < arr[i])
                {
                    secondLargestElement = largestElement;
                    largestElement = arr[i];
                }
            }

            Console.WriteLine("Largest Element : " + largestElement + ", Second Largest Element : " + secondLargestElement);
        }     
    }
}
