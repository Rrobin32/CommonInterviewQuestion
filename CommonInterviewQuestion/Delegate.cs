using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreperation
{
    internal class Delegate
    {
        public static void Main(string[] args)
        {
            Func<int, int, int> add = (x, y) => x + y;

            Console.WriteLine(add(3, 4));

            Console.ReadLine(); 
        }
    }
}
