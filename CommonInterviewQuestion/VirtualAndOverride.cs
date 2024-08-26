using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /*
     * Difference between virtual keyword and overriding?
     * Virtual keyword helps us to define some logic in parent class which can be overridden in the child class.
     */

    class baseClass
    {
        public virtual void show()
        {
            Console.WriteLine("Base class");
        }
    }

    class derived : baseClass
    {
        public override void show()
        {
            Console.WriteLine("Derived class");
        }
    }

    internal class VirtualAndOverride
    {
        public static void Main()
        {
            baseClass obj;

            obj = new baseClass();
            obj.show();

            obj = new derived();
            obj.show();

        }
    }
}
