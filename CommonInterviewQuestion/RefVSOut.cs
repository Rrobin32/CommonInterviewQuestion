using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class RefVSOut
    {
        public static void Main(string[] args)
        {
            int i = 5;
            int j;
            RefVSOut.M1(ref i);
            RefVSOut.M2(out j);
            Console.WriteLine(i + "  " + j);
        }

        private static void M1(ref int i)
        {
            i = i + i;
        }

        private static void M2(out int i)
        {
            i = 6;
            i = i * i;
        }
    }
}
