using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal sealed class SingletonImplementation
    {
        public SingletonImplementation() { }

        private static SingletonImplementation instance;
        public static SingletonImplementation singleton
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonImplementation();
                }
                return instance;
            }
        }
    }

    internal class Singleton
    {
        public static void Main(string[] args)
        {
            SingletonImplementation s1 = SingletonImplementation.singleton;
            SingletonImplementation s2 = SingletonImplementation.singleton;

            if (s1 == s2)
            {
                Console.WriteLine("Same Instance");
            }
        }
    }
}
