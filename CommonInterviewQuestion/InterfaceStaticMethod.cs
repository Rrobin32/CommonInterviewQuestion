using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    public interface IInterfaceStaticMethod
    {
        public static void InterfaceStaticMethod()
        {
            Console.WriteLine("Interface Static Method");
        }
    }

    internal class InterfaceStaticMethod
    {
        public static void Main(string[] args)
        {
            IInterfaceStaticMethod.InterfaceStaticMethod();
        }
    }
}
