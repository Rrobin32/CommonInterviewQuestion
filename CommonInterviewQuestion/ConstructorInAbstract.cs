using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /*
     Can an abstract class have a constructor?
    Yes, an abstract class can have constructor. If you want to initialise certain fields of abstract class before the instantiation 
    of child-class takes place.

    You cannot create an instance of an abstract class. So, what is use of constructor in an abstract class?
    Though we cannot create an instance of an abstract class, we can create instances of derived class. hence parent abstract class constructor is automatically called.

    Note: Abstract classes can’t be directly instantiated. The abstract class constructor gets executed thourgh derived class. So, it is good practice to use protected access modifier with abstract class constructor. using public doesn’t make sense
     */
    internal abstract class ConstructorInAbstract
    {
        protected ConstructorInAbstract()
        {
            Console.WriteLine("Abstract Class Constructor");
        }
    }

    class AbstractImplementation : ConstructorInAbstract
    {
        public AbstractImplementation()
        {
            Console.WriteLine("Abstract Impelentation Class Constructor");
        }
        public static void Main(string[] args)
        {
            AbstractImplementation abstractImplementation = new AbstractImplementation();
        }
    }
}
