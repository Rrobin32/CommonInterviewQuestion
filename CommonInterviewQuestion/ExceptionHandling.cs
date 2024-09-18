using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    class ExceptionHandling
    {
        public static void Main(string[] args)
        {

        }

        public string ReturnM()
        {
            try
            {
                int a = 10;
                int b = 20;
                int c = a / b;

                return "A";
            }
            catch (Exception ex)
            {
                return "B";
            }
            //catch(DivideByZeroException ex)
            //{

            //}
            finally
            {
                //return "C";
            }
            return "D";
        }
    }
}
