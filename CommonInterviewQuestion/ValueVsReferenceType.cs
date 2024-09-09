using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class ValueVsReferenceType
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            b = 20;

            List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> ints1 = ints;
            ints1.Add(6);

            Console.WriteLine("a : " + a + ", b: " + b);
            Console.WriteLine("ints count : " + ints.Count + ", ints1 count : " + ints1.Count);
        }
    }
}
