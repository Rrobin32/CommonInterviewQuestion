using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /*
     * Why do we need private constructor?
     * To restrict a class being inherited.
     * Restrict a class being instantiate or creating multiple instance/object.
     * To achieve the singleton design pattern.
     */
    internal class PrivateConstructor
    {
        static void Main(string[] args)
        {
            // calling the private constructor using class name directly 
            int result = TestPrivateConstructor.sum(10, 15);

            Console.WriteLine(result);
            //TestPrivateConstructor objClass = new TestPrivateConstructor(); 
            // Will throw the error. We can't create object of this class
        }
    }

    public class TestPrivateConstructor
    {
        private TestPrivateConstructor()
        { }

        public static int sum(int a, int b)
        {
            return a + b;
        }

        public void Print()
        {
            Console.WriteLine("print");
        }
    }

}
