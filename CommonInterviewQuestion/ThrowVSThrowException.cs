using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class ThrowVSThrowException
    {
        static void Main(string[] args)
        {
            try
            {
                ThrowException1();
            }
            catch (Exception x)
            {
                Console.WriteLine("Exception 1:");
                Console.WriteLine(x.StackTrace);
            }
            try
            {
                ThrowException2();
            }
            catch (Exception x)
            {
                Console.WriteLine("Exception 2:");
                Console.WriteLine(x.StackTrace);
            }
        }

        private static void ThrowException1()
        {
            try
            {
                DivByZero();
            }
            catch
            {
                throw;            }
        }
        private static void ThrowException2()
        {
            try
            {
                DivByZero();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void DivByZero()
        {
            int x = 0;
            int y = 1 / x;
        }

    }
}
