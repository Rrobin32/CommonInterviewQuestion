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
                int b = 0;
                int c = a / b;

                return "A";
            } 
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {

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
