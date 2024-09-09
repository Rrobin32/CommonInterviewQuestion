using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    public class ReverseArray
    {
        static string[] array = { "a", "b", "c" };
        public static void Main(string[] args)
        {
            var output = RevArray(array);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }

        public static string[] RevArray(string[] array)
        {
            string[] result = new string[array.Length];
            int index = 0;
            for (int i = array.Length; i > 0; i--)
            {
                result[index] = array[i - 1];
                index++;
            }
            return result;
        }
    }
}
