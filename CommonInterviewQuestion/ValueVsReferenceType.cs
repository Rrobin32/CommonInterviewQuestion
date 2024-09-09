using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /*
        Value Types: Store data directly and are allocated on the stack. This means that when you assign one value type to another, 
        a direct copy of the value is created. Basic data types (int, double, bool, etc.) and structs are examples of value types. 
        Operations on value types are generally faster due to stack allocation.

        Reference Types: Store a reference (or pointer) to the actual data, which is allocated on the heap. When you assign one reference type to another, 
        both refer to the same object in memory; changes made through one reference are reflected in the other. Classes, arrays, delegates, and strings are examples of 
        reference types.
     */
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
