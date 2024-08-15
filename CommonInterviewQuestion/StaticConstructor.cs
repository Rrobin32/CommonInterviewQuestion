using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreperation
{
    public class Parent
    {
        //private Parent()
        //{
        //    Console.WriteLine("In Parent");
        //}
        public Parent()
        {
            Console.WriteLine("In Parent");
        }

        static Parent()
        {
            Console.WriteLine("In Static Parent");
        }

        public void Method()
        {
            Console.WriteLine("In Method Parent");
        }
    }

    public class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("In Child");
        }

        static Child()
        {
            Console.WriteLine("In Static Child");
        }

        public void Method()
        {
            Console.WriteLine("In Method Child");
        }
    }
    public class StaticConstructor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("First Object");
            Parent parent = new Parent();
            parent.Method();
            Console.WriteLine();

            Console.WriteLine("Second Object");
            Parent parent1 = new Child();
            parent1.Method();
            Console.WriteLine();

            Console.WriteLine("Third Object");
            Child child = new Child();
            child.Method();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
