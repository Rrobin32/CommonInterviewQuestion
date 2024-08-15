using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreperation
{
    public class ConstVSReadonly
    {
        readonly int read = 10;
        const int cons = 10;
        //public Test()
        //{
        //    read = 100;
        //    cons = 100;
        //}

        public static void Main(string[] args)
        {
            ConstVSReadonly constVSReadonly = new ConstVSReadonly();
            constVSReadonly.Check();
        }
        public void Check()
        {
            Console.WriteLine("Read only : {0}", read);
            Console.WriteLine("const : {0}", cons);
            Console.ReadLine();
        }
    }
}
