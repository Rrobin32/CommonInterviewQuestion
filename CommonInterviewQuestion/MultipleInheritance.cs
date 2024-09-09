using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    interface A
    {
        public void Print();
    }
    interface B
    {
        public void Print();
    }
    class MultipleInheritance : A, B
    {
        void A.Print()
        {
            Console.WriteLine("Interface A Print Method.");
        }
        void B.Print()
        {
            Console.WriteLine("Interface B Print Method.");
        }

        public static void Main(string[] args)
        {
            var a = new MultipleInheritance();
            A interfaceA = a;
            B interfaceB = a;
            interfaceA.Print();
            interfaceB.Print();
        }
    }
}
