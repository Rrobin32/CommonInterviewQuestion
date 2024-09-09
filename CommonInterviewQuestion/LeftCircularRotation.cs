using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    /*
     * Left circular rotation of an array
     * 1 2 3 4 5 => 2 3 4 5 1 
     */
    internal class LeftCircularRotation
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            TraverseArray(array);
        }

        public static void TraverseArray(int[] array)
        {
            int temp;
            for (int i = array.Length - 1; i > 0; i--)
            {
                temp = array[array.Length - 1];
                array[array.Length - 1] = array[i - 1];
                array[i - 1] = temp;
            }

            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}
