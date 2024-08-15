using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreperation
{
    internal class LinqExample
    {
        static public void Main()
        {

            // Creating data source 
            string[] language = {"C#", "VB", "Java", "C++",
                        "C", "Perl", "Ruby", "Python"};

            // Creating a query to get the  
            // value from the data source 
            var result = from lang in language
                         where lang.Contains('C')
                         select lang;

            // display the result of the query 
            foreach (var l in result)
            {
                Console.WriteLine(l);
            }
        }
    }
}
