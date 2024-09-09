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
                return "A";
            }
            catch (Exception ex)
            {
                return "B";
            }
            finally
            {
                //return "C";
            }
            return "D";
        }
    }
}
