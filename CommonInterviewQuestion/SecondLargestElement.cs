﻿using System;
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
            int largestElement = int.MinValue, secondLargestElement = int.MinValue;
            foreach (int i in arr)
            {
                if (i > largestElement)
                {
                    secondLargestElement = largestElement;
                    largestElement = i;
                }
                else if (i >= secondLargestElement && i != largestElement)
                {
                    secondLargestElement = i;
                }
            }

            Console.WriteLine("Largest Element : " + largestElement + ", Second Largest Element : " + secondLargestElement);
        }     
    }
}
