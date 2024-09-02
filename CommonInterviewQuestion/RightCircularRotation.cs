using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /*
    * Right circular rotation of an array
    * 1 2 3 4 5 => 5 1 2 3 4
    */
    internal class RightCircularRotation
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            TraverseArray(array);
        }

        public static void TraverseArray(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                temp = array[0];
                array[0] = array[i + 1];
                array[i + 1] = temp;
            }

            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}
